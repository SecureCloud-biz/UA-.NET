/* ========================================================================
 * Copyright (c) 2005-2017 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Opc.Ua;
using Opc.Ua.Server;
using Opc.Ua.Com.Client;

namespace TutorialServer
{
    /// <summary>
    /// Implements a basic Server.
    /// </summary>
    /// <remarks>
    /// Each server instance must have one instance of a StandardServer object which is
    /// responsible for reading the configuration file, creating the endpoints and dispatching
    /// incoming requests to the appropriate handler.
    /// 
    /// This sub-class specifies non-configurable metadata such as Product Name and initializes
    /// the TutorialNodeManager which provides access to the data exposed by the Server.
    /// </remarks>
    public partial class TutorialServer : StandardServer
    {
        #region Overridden Methods
        /// <summary>
        /// Creates the node managers for the server.
        /// </summary>
        /// <remarks>
        /// This method allows the sub-class create any additional node managers which it uses. The SDK
        /// always creates a CoreNodeManager which handles the built-in nodes defined by the specification.
        /// Any additional NodeManagers are expected to handle application specific nodes.
        /// </remarks>
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            Utils.Trace("Creating the Node Managers.");

            List<INodeManager> nodeManagers = new List<INodeManager>();

            // create the custom node managers.
            nodeManagers.Add(new TutorialNodeManager(server, configuration));

            #region Task #C4 - Add Support for COM Wrapper
            // manually configure the COM server to prevent unapproved wrappers.
            ComDaClientConfiguration wrapperConfig = new ComDaClientConfiguration();

            wrapperConfig.ServerName = "COM";
            wrapperConfig.ServerUrl = "opc.com://localhost/OPCSample.OpcDaServer";
            wrapperConfig.MaxReconnectWait = 10000;
            wrapperConfig.SeperatorChars = null;
            wrapperConfig.BrowseToNotSupported = false;
            wrapperConfig.ItemIdParser = new ItemIdParser();

            // create an instance of the wrapper node manager.
            TutorialDaComNodeManager manager = new TutorialDaComNodeManager(
                server,
                wrapperConfig.ServerUrl,
                wrapperConfig,
                true);

            nodeManagers.Add(manager);
            #endregion

            // create master node manager.
            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        }

        /// <summary>
        /// Loads the non-configurable properties for the application.
        /// </summary>
        /// <remarks>
        /// These properties are exposed by the server but cannot be changed by administrators.
        /// </remarks>
        protected override ServerProperties LoadServerProperties()
        {
            ServerProperties properties = new ServerProperties();

            properties.ManufacturerName = "OPC Foundation";
            properties.ProductName      = "Tutorial Server";
            properties.ProductUri       = "http://opcfoundation.org/TutorialServer/v1.0";
            properties.SoftwareVersion  = Utils.GetAssemblySoftwareVersion();
            properties.BuildNumber      = Utils.GetAssemblyBuildNumber();
            properties.BuildDate        = Utils.GetAssemblyTimestamp();

            // TBD - All applications have software certificates that need to added to the properties.

            return properties;
        }
        #endregion

        #region Task #D2 - Add Support for User Authentication
        /// <summary>
        /// Called after the server has been started.
        /// </summary>
        protected override void OnServerStarted(IServerInternal server)
        {
            base.OnServerStarted(server);

            // request notifications when the user identity is changed. all valid users are accepted by default.
            server.SessionManager.ImpersonateUser += new ImpersonateEventHandler(SessionManager_ImpersonateUser);
        }

        /// <summary>
        /// Called when a client tries to change its user identity.
        /// </summary>
        private void SessionManager_ImpersonateUser(Session session, ImpersonateEventArgs args)
        {
            // check for a user name token.
            UserNameIdentityToken userNameToken = args.NewIdentity as UserNameIdentityToken;

            if (userNameToken != null)
            {
                VerifyPassword(userNameToken.UserName, userNameToken.DecryptedPassword);
                args.Identity = new UserIdentity(userNameToken);
                Utils.Trace("UserName Token Accepted: {0}", args.Identity.DisplayName);
                return;
            }
        }

        /// <summary>
        /// Validates the password for a username token.
        /// </summary>
        private void VerifyPassword(string userName, string password)
        {
            if (String.IsNullOrEmpty(password))
            {
                // specify arguments to use when formatting the lcoalized text,
                TranslationInfo info = new TranslationInfo(TutorialErrorCodes.InvalidPassword, userName);

                // create an error with a vendor defined sub-code and the translation info.
                ServiceResult error = new ServiceResult(
                    StatusCodes.BadIdentityTokenRejected, 
                    TutorialErrorCodes.InvalidPassword,
                    new LocalizedText(info));

                // throw the exception.
                throw new ServiceResultException(error);
            }
        }
        #endregion

        #region Task #D1 - Add Support for Localized Errors
        /// <summary>
        /// Creates the resource manager for the server.
        /// </summary>
        protected override ResourceManager CreateResourceManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            ResourceManager resourceManager = new ResourceManager(server, configuration);

            // load default text for all status codes.
            resourceManager.LoadDefaultText();

            // add translations for standard error codes.
            resourceManager.Add(StatusCodes.BadUserAccessDenied, "en-US", "User does not have permission to perform the requested operation.");
            resourceManager.Add(StatusCodes.BadUserAccessDenied, "fr-FR", "Utilisateur ne peut pas changer la valeur.");
            resourceManager.Add(StatusCodes.BadUserAccessDenied, "de-DE", "User nicht ändern können, Wert.");

            // add translations for server defined error codes.
            resourceManager.Add(TutorialErrorCodes.InvalidPassword, "en-US", "Specified password is not valid for user '{0}'.");
            resourceManager.Add(TutorialErrorCodes.InvalidPassword, "de-DE", "Das Passwort ist nicht gültig für Konto '{0}'.");
            resourceManager.Add(TutorialErrorCodes.InvalidPassword, "es-ES", "La contraseña no es válida para la cuenta de '{0}'.");

            return resourceManager;
        }
        #endregion

        #region Task #C4 - Add Support for COM Wrapper
        /// <summary>
        /// A class which can use the server's item id syntax to optimize browsing.
        /// </summary>
        private class ItemIdParser : IItemIdParser
        {
            #region IItemIdParser Members
            public bool Parse(ComObject server, ComClientConfiguration configuration, string itemId, out string browseName)
            {
                browseName = String.Empty;

                if (String.IsNullOrEmpty(itemId))
                {
                    return true;
                }

                browseName = itemId;

                int index = itemId.LastIndexOf('/');

                if (index == -1)
                {
                    return true;
                }

                browseName = browseName.Substring(0, index + 1);
                return true;
            }
            #endregion
        }
        #endregion
    }

    #region Task #D1 - Add Support for Localized Errors
    /// <summary>
    /// Defines error codes used by the server.
    /// </summary>
    public static class TutorialErrorCodes
    {
        public static readonly XmlQualifiedName InvalidPassword = new XmlQualifiedName("InvalidPassword", Namespaces.Tutorial);
    }
    #endregion
}
