/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CognitoIdentity.Model;
using Amazon.CognitoIdentity.Model.Internal.MarshallTransformations;
using Amazon.CognitoIdentity.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CognitoIdentity
{
    /// <summary>
    /// Implementation for accessing CognitoIdentity
    ///
    /// Amazon Cognito 
    /// <para>
    /// Amazon Cognito is a web service that delivers scoped temporary credentials to mobile
    /// devices and other untrusted environments. Amazon Cognito uniquely identifies a device
    /// and supplies the user with a consistent identity over the lifetime of an application.
    /// </para>
    ///  
    /// <para>
    /// Using Amazon Cognito, you can enable authentication with one or more third-party identity
    /// providers (Facebook, Google, or Login with Amazon), and you can also choose to support
    /// unauthenticated access from your app. Cognito delivers a unique identifier for each
    /// user and acts as an OpenID token provider trusted by AWS Security Token Service (STS)
    /// to access temporary, limited-privilege AWS credentials.
    /// </para>
    ///  
    /// <para>
    /// To provide end-user credentials, first make an unsigned call to <a>GetId</a>. If the
    /// end user is authenticated with one of the supported identity providers, set the <code>Logins</code>
    /// map with the identity provider token. <code>GetId</code> returns a unique identifier
    /// for the user.
    /// </para>
    ///  
    /// <para>
    /// Next, make an unsigned call to <a>GetCredentialsForIdentity</a>. This call expects
    /// the same <code>Logins</code> map as the <code>GetId</code> call, as well as the <code>IdentityID</code>
    /// originally returned by <code>GetId</code>. Assuming your identity pool has been configured
    /// via the <a>SetIdentityPoolRoles</a> operation, <code>GetCredentialsForIdentity</code>
    /// will return AWS credentials for your use. If your pool has not been configured with
    /// <code>SetIdentityPoolRoles</code>, or if you want to follow legacy flow, make an unsigned
    /// call to <a>GetOpenIdToken</a>, which returns the OpenID token necessary to call STS
    /// and retrieve AWS credentials. This call expects the same <code>Logins</code> map as
    /// the <code>GetId</code> call, as well as the <code>IdentityID</code> originally returned
    /// by <code>GetId</code>. The token returned by <code>GetOpenIdToken</code> can be passed
    /// to the STS operation <a href="http://docs.aws.amazon.com/STS/latest/APIReference/API_AssumeRoleWithWebIdentity.html">AssumeRoleWithWebIdentity</a>
    /// to retrieve AWS credentials.
    /// </para>
    ///  
    /// <para>
    /// If you want to use Amazon Cognito in an Android, iOS, or Unity application, you will
    /// probably want to make API calls via the AWS Mobile SDK. To learn more, see the <a
    /// href="http://docs.aws.amazon.com/mobile/index.html">AWS Mobile SDK Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCognitoIdentityClient : AmazonServiceClient, IAmazonCognitoIdentity
    {
        private static IServiceMetadata serviceMetadata = new AmazonCognitoIdentityMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCognitoIdentityClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCognitoIdentityConfig()) { }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoIdentityClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCognitoIdentityConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCognitoIdentityClient Configuration Object</param>
        public AmazonCognitoIdentityClient(AmazonCognitoIdentityConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCognitoIdentityClient(AWSCredentials credentials)
            : this(credentials, new AmazonCognitoIdentityConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoIdentityClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCognitoIdentityConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Credentials and an
        /// AmazonCognitoIdentityClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCognitoIdentityClient Configuration Object</param>
        public AmazonCognitoIdentityClient(AWSCredentials credentials, AmazonCognitoIdentityConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCognitoIdentityConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCognitoIdentityConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCognitoIdentityClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCognitoIdentityClient Configuration Object</param>
        public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCognitoIdentityConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCognitoIdentityConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCognitoIdentityConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoIdentityClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCognitoIdentityClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCognitoIdentityClient Configuration Object</param>
        public AmazonCognitoIdentityClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCognitoIdentityConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CreateIdentityPool

        internal virtual CreateIdentityPoolResponse CreateIdentityPool(CreateIdentityPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIdentityPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentityPoolResponseUnmarshaller.Instance;

            return Invoke<CreateIdentityPoolResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/CreateIdentityPool">REST API Reference for CreateIdentityPool Operation</seealso>
        public virtual Task<CreateIdentityPoolResponse> CreateIdentityPoolAsync(CreateIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIdentityPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentityPoolResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIdentityPoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIdentities

        internal virtual DeleteIdentitiesResponse DeleteIdentities(DeleteIdentitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentitiesResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentitiesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DeleteIdentities">REST API Reference for DeleteIdentities Operation</seealso>
        public virtual Task<DeleteIdentitiesResponse> DeleteIdentitiesAsync(DeleteIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentitiesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIdentitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIdentityPool

        internal virtual DeleteIdentityPoolResponse DeleteIdentityPool(DeleteIdentityPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentityPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityPoolResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentityPoolResponse>(request, options);
        }


        /// <summary>
        /// Deletes a user pool. Once a pool is deleted, users will not be able to authenticate
        /// with the pool.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="identityPoolId">An identity pool ID in the format REGION:GUID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIdentityPool service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DeleteIdentityPool">REST API Reference for DeleteIdentityPool Operation</seealso>
        public virtual Task<DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(string identityPoolId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteIdentityPoolRequest();
            request.IdentityPoolId = identityPoolId;
            return DeleteIdentityPoolAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DeleteIdentityPool">REST API Reference for DeleteIdentityPool Operation</seealso>
        public virtual Task<DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(DeleteIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIdentityPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentityPoolResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIdentityPoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeIdentity

        internal virtual DescribeIdentityResponse DescribeIdentity(DescribeIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityResponse>(request, options);
        }


        /// <summary>
        /// Returns metadata related to the given identity, including when the identity was created
        /// and any associated linked logins.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="identityId">A unique identifier in the format REGION:GUID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIdentity service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DescribeIdentity">REST API Reference for DescribeIdentity Operation</seealso>
        public virtual Task<DescribeIdentityResponse> DescribeIdentityAsync(string identityId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeIdentityRequest();
            request.IdentityId = identityId;
            return DescribeIdentityAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DescribeIdentity">REST API Reference for DescribeIdentity Operation</seealso>
        public virtual Task<DescribeIdentityResponse> DescribeIdentityAsync(DescribeIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeIdentityPool

        internal virtual DescribeIdentityPoolResponse DescribeIdentityPool(DescribeIdentityPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityPoolResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityPoolResponse>(request, options);
        }


        /// <summary>
        /// Gets details about a particular identity pool, including the pool name, ID description,
        /// creation date, and current number of users.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="identityPoolId">An identity pool ID in the format REGION:GUID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIdentityPool service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DescribeIdentityPool">REST API Reference for DescribeIdentityPool Operation</seealso>
        public virtual Task<DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(string identityPoolId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeIdentityPoolRequest();
            request.IdentityPoolId = identityPoolId;
            return DescribeIdentityPoolAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/DescribeIdentityPool">REST API Reference for DescribeIdentityPool Operation</seealso>
        public virtual Task<DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(DescribeIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityPoolResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIdentityPoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCredentialsForIdentity

        internal virtual GetCredentialsForIdentityResponse GetCredentialsForIdentity(GetCredentialsForIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCredentialsForIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCredentialsForIdentityResponseUnmarshaller.Instance;

            return Invoke<GetCredentialsForIdentityResponse>(request, options);
        }


        /// <summary>
        /// Returns credentials for the provided identity ID. Any provided logins will be validated
        /// against supported login providers. If the token is for cognito-identity.amazonaws.com,
        /// it will be passed through to AWS Security Token Service with the appropriate role
        /// for the token.
        /// 
        ///  
        /// <para>
        /// This is a public API. You do not need any credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="identityId">A unique identifier in the format REGION:GUID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCredentialsForIdentity service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.ExternalServiceException">
        /// An exception thrown when a dependent service such as Facebook or Twitter is not responding
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidIdentityPoolConfigurationException">
        /// Thrown if the identity pool has no role associated for the given auth type (auth/unauth)
        /// or if the AssumeRole fails.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetCredentialsForIdentity">REST API Reference for GetCredentialsForIdentity Operation</seealso>
        public virtual Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(string identityId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetCredentialsForIdentityRequest();
            request.IdentityId = identityId;
            return GetCredentialsForIdentityAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns credentials for the provided identity ID. Any provided logins will be validated
        /// against supported login providers. If the token is for cognito-identity.amazonaws.com,
        /// it will be passed through to AWS Security Token Service with the appropriate role
        /// for the token.
        /// 
        ///  
        /// <para>
        /// This is a public API. You do not need any credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="identityId">A unique identifier in the format REGION:GUID.</param>
        /// <param name="logins">A set of optional name-value pairs that map provider names to provider tokens.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCredentialsForIdentity service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.ExternalServiceException">
        /// An exception thrown when a dependent service such as Facebook or Twitter is not responding
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidIdentityPoolConfigurationException">
        /// Thrown if the identity pool has no role associated for the given auth type (auth/unauth)
        /// or if the AssumeRole fails.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetCredentialsForIdentity">REST API Reference for GetCredentialsForIdentity Operation</seealso>
        public virtual Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(string identityId, Dictionary<string, string> logins, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetCredentialsForIdentityRequest();
            request.IdentityId = identityId;
            request.Logins = logins;
            return GetCredentialsForIdentityAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCredentialsForIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialsForIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetCredentialsForIdentity">REST API Reference for GetCredentialsForIdentity Operation</seealso>
        public virtual Task<GetCredentialsForIdentityResponse> GetCredentialsForIdentityAsync(GetCredentialsForIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCredentialsForIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCredentialsForIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<GetCredentialsForIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetId

        internal virtual GetIdResponse GetId(GetIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdResponseUnmarshaller.Instance;

            return Invoke<GetIdResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetId operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetId">REST API Reference for GetId Operation</seealso>
        public virtual Task<GetIdResponse> GetIdAsync(GetIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIdentityPoolRoles

        internal virtual GetIdentityPoolRolesResponse GetIdentityPoolRoles(GetIdentityPoolRolesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityPoolRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityPoolRolesResponseUnmarshaller.Instance;

            return Invoke<GetIdentityPoolRolesResponse>(request, options);
        }


        /// <summary>
        /// Gets the roles for an identity pool.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="identityPoolId">An identity pool ID in the format REGION:GUID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdentityPoolRoles service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetIdentityPoolRoles">REST API Reference for GetIdentityPoolRoles Operation</seealso>
        public virtual Task<GetIdentityPoolRolesResponse> GetIdentityPoolRolesAsync(string identityPoolId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetIdentityPoolRolesRequest();
            request.IdentityPoolId = identityPoolId;
            return GetIdentityPoolRolesAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityPoolRoles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPoolRoles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetIdentityPoolRoles">REST API Reference for GetIdentityPoolRoles Operation</seealso>
        public virtual Task<GetIdentityPoolRolesResponse> GetIdentityPoolRolesAsync(GetIdentityPoolRolesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdentityPoolRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentityPoolRolesResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdentityPoolRolesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOpenIdToken

        internal virtual GetOpenIdTokenResponse GetOpenIdToken(GetOpenIdTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpenIdTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpenIdTokenResponseUnmarshaller.Instance;

            return Invoke<GetOpenIdTokenResponse>(request, options);
        }


        /// <summary>
        /// Gets an OpenID token, using a known Cognito ID. This known Cognito ID is returned
        /// by <a>GetId</a>. You can optionally add additional logins for the identity. Supplying
        /// multiple logins creates an implicit link.
        /// 
        ///  
        /// <para>
        /// The OpenId token is valid for 15 minutes.
        /// </para>
        ///  
        /// <para>
        /// This is a public API. You do not need any credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="identityId">A unique identifier in the format REGION:GUID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOpenIdToken service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.ExternalServiceException">
        /// An exception thrown when a dependent service such as Facebook or Twitter is not responding
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetOpenIdToken">REST API Reference for GetOpenIdToken Operation</seealso>
        public virtual Task<GetOpenIdTokenResponse> GetOpenIdTokenAsync(string identityId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetOpenIdTokenRequest();
            request.IdentityId = identityId;
            return GetOpenIdTokenAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetOpenIdToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIdToken operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetOpenIdToken">REST API Reference for GetOpenIdToken Operation</seealso>
        public virtual Task<GetOpenIdTokenResponse> GetOpenIdTokenAsync(GetOpenIdTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpenIdTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpenIdTokenResponseUnmarshaller.Instance;

            return InvokeAsync<GetOpenIdTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOpenIdTokenForDeveloperIdentity

        internal virtual GetOpenIdTokenForDeveloperIdentityResponse GetOpenIdTokenForDeveloperIdentity(GetOpenIdTokenForDeveloperIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpenIdTokenForDeveloperIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller.Instance;

            return Invoke<GetOpenIdTokenForDeveloperIdentityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetOpenIdTokenForDeveloperIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIdTokenForDeveloperIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/GetOpenIdTokenForDeveloperIdentity">REST API Reference for GetOpenIdTokenForDeveloperIdentity Operation</seealso>
        public virtual Task<GetOpenIdTokenForDeveloperIdentityResponse> GetOpenIdTokenForDeveloperIdentityAsync(GetOpenIdTokenForDeveloperIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpenIdTokenForDeveloperIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpenIdTokenForDeveloperIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<GetOpenIdTokenForDeveloperIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIdentities

        internal virtual ListIdentitiesResponse ListIdentities(ListIdentitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListIdentitiesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/ListIdentities">REST API Reference for ListIdentities Operation</seealso>
        public virtual Task<ListIdentitiesResponse> ListIdentitiesAsync(ListIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdentitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIdentityPools

        internal virtual ListIdentityPoolsResponse ListIdentityPools(ListIdentityPoolsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityPoolsResponseUnmarshaller.Instance;

            return Invoke<ListIdentityPoolsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityPools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPools operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/ListIdentityPools">REST API Reference for ListIdentityPools Operation</seealso>
        public virtual Task<ListIdentityPoolsResponse> ListIdentityPoolsAsync(ListIdentityPoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIdentityPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentityPoolsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdentityPoolsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  LookupDeveloperIdentity

        internal virtual LookupDeveloperIdentityResponse LookupDeveloperIdentity(LookupDeveloperIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LookupDeveloperIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LookupDeveloperIdentityResponseUnmarshaller.Instance;

            return Invoke<LookupDeveloperIdentityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the LookupDeveloperIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LookupDeveloperIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/LookupDeveloperIdentity">REST API Reference for LookupDeveloperIdentity Operation</seealso>
        public virtual Task<LookupDeveloperIdentityResponse> LookupDeveloperIdentityAsync(LookupDeveloperIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LookupDeveloperIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LookupDeveloperIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<LookupDeveloperIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MergeDeveloperIdentities

        internal virtual MergeDeveloperIdentitiesResponse MergeDeveloperIdentities(MergeDeveloperIdentitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MergeDeveloperIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergeDeveloperIdentitiesResponseUnmarshaller.Instance;

            return Invoke<MergeDeveloperIdentitiesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the MergeDeveloperIdentities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MergeDeveloperIdentities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/MergeDeveloperIdentities">REST API Reference for MergeDeveloperIdentities Operation</seealso>
        public virtual Task<MergeDeveloperIdentitiesResponse> MergeDeveloperIdentitiesAsync(MergeDeveloperIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MergeDeveloperIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergeDeveloperIdentitiesResponseUnmarshaller.Instance;

            return InvokeAsync<MergeDeveloperIdentitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetIdentityPoolRoles

        internal virtual SetIdentityPoolRolesResponse SetIdentityPoolRoles(SetIdentityPoolRolesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetIdentityPoolRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIdentityPoolRolesResponseUnmarshaller.Instance;

            return Invoke<SetIdentityPoolRolesResponse>(request, options);
        }


        /// <summary>
        /// Sets the roles for an identity pool. These roles are used when making calls to <a>GetCredentialsForIdentity</a>
        /// action.
        /// 
        ///  
        /// <para>
        /// You must use AWS Developer credentials to call this API.
        /// </para>
        /// </summary>
        /// <param name="identityPoolId">An identity pool ID in the format REGION:GUID.</param>
        /// <param name="roles">The map of roles associated with this pool. For a given role, the key will be either "authenticated" or "unauthenticated" and the value will be the Role ARN.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetIdentityPoolRoles service method, as returned by CognitoIdentity.</returns>
        /// <exception cref="Amazon.CognitoIdentity.Model.ConcurrentModificationException">
        /// Thrown if there are parallel requests to modify a resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InternalErrorException">
        /// Thrown when the service encounters an error during processing the request.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.InvalidParameterException">
        /// Thrown for missing or bad input parameter(s).
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.NotAuthorizedException">
        /// Thrown when a user is not authorized to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceConflictException">
        /// Thrown when a user tries to use a login which is already linked to another account.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.ResourceNotFoundException">
        /// Thrown when the requested resource (for example, a dataset or record) does not exist.
        /// </exception>
        /// <exception cref="Amazon.CognitoIdentity.Model.TooManyRequestsException">
        /// Thrown when a request is throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/SetIdentityPoolRoles">REST API Reference for SetIdentityPoolRoles Operation</seealso>
        public virtual Task<SetIdentityPoolRolesResponse> SetIdentityPoolRolesAsync(string identityPoolId, Dictionary<string, string> roles, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new SetIdentityPoolRolesRequest();
            request.IdentityPoolId = identityPoolId;
            request.Roles = roles;
            return SetIdentityPoolRolesAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityPoolRoles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityPoolRoles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/SetIdentityPoolRoles">REST API Reference for SetIdentityPoolRoles Operation</seealso>
        public virtual Task<SetIdentityPoolRolesResponse> SetIdentityPoolRolesAsync(SetIdentityPoolRolesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetIdentityPoolRolesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIdentityPoolRolesResponseUnmarshaller.Instance;

            return InvokeAsync<SetIdentityPoolRolesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnlinkDeveloperIdentity

        internal virtual UnlinkDeveloperIdentityResponse UnlinkDeveloperIdentity(UnlinkDeveloperIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnlinkDeveloperIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnlinkDeveloperIdentityResponseUnmarshaller.Instance;

            return Invoke<UnlinkDeveloperIdentityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UnlinkDeveloperIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnlinkDeveloperIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/UnlinkDeveloperIdentity">REST API Reference for UnlinkDeveloperIdentity Operation</seealso>
        public virtual Task<UnlinkDeveloperIdentityResponse> UnlinkDeveloperIdentityAsync(UnlinkDeveloperIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnlinkDeveloperIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnlinkDeveloperIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<UnlinkDeveloperIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnlinkIdentity

        internal virtual UnlinkIdentityResponse UnlinkIdentity(UnlinkIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnlinkIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnlinkIdentityResponseUnmarshaller.Instance;

            return Invoke<UnlinkIdentityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UnlinkIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnlinkIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/UnlinkIdentity">REST API Reference for UnlinkIdentity Operation</seealso>
        public virtual Task<UnlinkIdentityResponse> UnlinkIdentityAsync(UnlinkIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnlinkIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnlinkIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<UnlinkIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateIdentityPool

        internal virtual UpdateIdentityPoolResponse UpdateIdentityPool(UpdateIdentityPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityPoolResponseUnmarshaller.Instance;

            return Invoke<UpdateIdentityPoolResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdentityPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cognito-identity-2014-06-30/UpdateIdentityPool">REST API Reference for UpdateIdentityPool Operation</seealso>
        public virtual Task<UpdateIdentityPoolResponse> UpdateIdentityPoolAsync(UpdateIdentityPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityPoolResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIdentityPoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}