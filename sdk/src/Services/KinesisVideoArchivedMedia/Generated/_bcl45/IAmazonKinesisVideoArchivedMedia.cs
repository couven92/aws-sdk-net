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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.KinesisVideoArchivedMedia.Model;

namespace Amazon.KinesisVideoArchivedMedia
{
    /// <summary>
    /// Interface for accessing KinesisVideoArchivedMedia
    ///
    /// 
    /// </summary>
    public partial interface IAmazonKinesisVideoArchivedMedia : IAmazonService, IDisposable
    {

        
        #region  GetHLSStreamingSessionURL


        /// <summary>
        /// Retrieves an HTTP Live Streaming (HLS) URL for the stream. You can then open the URL
        /// in a browser or media player to view the stream contents.
        /// 
        ///  
        /// <para>
        /// You must specify either the <code>StreamName</code> or the <code>StreamARN</code>.
        /// </para>
        ///  
        /// <para>
        /// An Amazon Kinesis video stream has the following requirements for providing data through
        /// HLS:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The media must contain h.264 encoded video and, optionally, AAC encoded audio. Specifically,
        /// the codec id of track 1 should be <code>V_MPEG/ISO/AVC</code>. Optionally, the codec
        /// id of track 2 should be <code>A_AAC</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data retention must be greater than 0.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The video track of each fragment must contain codec private data in the Advanced Video
        /// Coding (AVC) for H.264 format (<a href="https://www.iso.org/standard/55980.html">MPEG-4
        /// specification ISO/IEC 14496-15</a>). For information about adapting stream data to
        /// a given format, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/producer-reference-nal.html">NAL
        /// Adaptation Flags</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The audio track (if present) of each fragment must contain codec private data in the
        /// AAC format (<a href="https://www.iso.org/standard/43345.html">AAC specification ISO/IEC
        /// 13818-7</a>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Kinesis Video Streams HLS sessions contain fragments in the fragmented MPEG-4 form
        /// (also called fMP4 or CMAF), rather than the MPEG-2 form (also called TS chunks, which
        /// the HLS specification also supports). For more information about HLS fragment types,
        /// see the <a href="https://tools.ietf.org/html/draft-pantos-http-live-streaming-23">HLS
        /// specification</a>.
        /// </para>
        ///  
        /// <para>
        /// The following procedure shows how to use HLS with Kinesis Video Streams:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Get an endpoint using <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_GetDataEndpoint.html">GetDataEndpoint</a>,
        /// specifying <code>GET_HLS_STREAMING_SESSION_URL</code> for the <code>APIName</code>
        /// parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Retrieve the HLS URL using <code>GetHLSStreamingSessionURL</code>. Kinesis Video Streams
        /// creates an HLS streaming session to be used for accessing content in a stream using
        /// the HLS protocol. <code>GetHLSStreamingSessionURL</code> returns an authenticated
        /// URL (that includes an encrypted session token) for the session's HLS <i>master playlist</i>
        /// (the root resource needed for streaming with HLS).
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't share or store this token where an unauthorized entity could access it. The
        /// token provides access to the content of the stream. Safeguard the token with the same
        /// measures that you would use with your AWS credentials.
        /// </para>
        ///  </note> 
        /// <para>
        /// The media that is made available through the playlist consists only of the requested
        /// stream, time range, and format. No other media data (such as frames outside the requested
        /// window or alternate bitrates) is made available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provide the URL (containing the encrypted session token) for the HLS master playlist
        /// to a media player that supports the HLS protocol. Kinesis Video Streams makes the
        /// HLS media playlist, initialization fragment, and media fragments available through
        /// the master playlist URL. The initialization fragment contains the codec private data
        /// for the stream, and other data needed to set up the video or audio decoder and renderer.
        /// The media fragments contain H.264-encoded video frames or AAC-encoded audio samples.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The media player receives the authenticated URL and requests stream metadata and media
        /// data normally. When the media player requests data, it calls the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>GetHLSMasterPlaylist:</b> Retrieves an HLS master playlist, which contains a URL
        /// for the <code>GetHLSMediaPlaylist</code> action for each track, and additional metadata
        /// for the media player, including estimated bitrate and resolution.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GetHLSMediaPlaylist:</b> Retrieves an HLS media playlist, which contains a URL
        /// to access the MP4 initialization fragment with the <code>GetMP4InitFragment</code>
        /// action, and URLs to access the MP4 media fragments with the <code>GetMP4MediaFragment</code>
        /// actions. The HLS media playlist also contains metadata about the stream that the player
        /// needs to play it, such as whether the <code>PlaybackMode</code> is <code>LIVE</code>
        /// or <code>ON_DEMAND</code>. The HLS media playlist is typically static for sessions
        /// with a <code>PlaybackType</code> of <code>ON_DEMAND</code>. The HLS media playlist
        /// is continually updated with new fragments for sessions with a <code>PlaybackType</code>
        /// of <code>LIVE</code>. There is a distinct HLS media playlist for the video track and
        /// the audio track (if applicable) that contains MP4 media URLs for the specific track.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GetMP4InitFragment:</b> Retrieves the MP4 initialization fragment. The media player
        /// typically loads the initialization fragment before loading any media fragments. This
        /// fragment contains the "<code>fytp</code>" and "<code>moov</code>" MP4 atoms, and the
        /// child atoms that are needed to initialize the media player decoder.
        /// </para>
        ///  
        /// <para>
        /// The initialization fragment does not correspond to a fragment in a Kinesis video stream.
        /// It contains only the codec private data for the stream and respective track, which
        /// the media player needs to decode the media frames.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GetMP4MediaFragment:</b> Retrieves MP4 media fragments. These fragments contain
        /// the "<code>moof</code>" and "<code>mdat</code>" MP4 atoms and their child atoms, containing
        /// the encoded fragment's media frames and their timestamps. 
        /// </para>
        ///  <note> 
        /// <para>
        /// After the first media fragment is made available in a streaming session, any fragments
        /// that don't contain the same codec private data cause an error to be returned when
        /// those different media fragments are loaded. Therefore, the codec private data should
        /// not change between fragments in a session. This also means that the session fails
        /// if the fragments in a stream change from having only video to having both audio and
        /// video.
        /// </para>
        ///  </note> 
        /// <para>
        /// Data retrieved with this action is billable. See <a href="https://aws.amazon.com/kinesis/video-streams/pricing/">Pricing</a>
        /// for details.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GetTSFragment:</b> Retrieves MPEG TS fragments containing both initialization
        /// and media data for all tracks in the stream.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the <code>ContainerFormat</code> is <code>MPEG_TS</code>, this API is used instead
        /// of <code>GetMP4InitFragment</code> and <code>GetMP4MediaFragment</code> to retrieve
        /// stream media.
        /// </para>
        ///  </note> 
        /// <para>
        /// Data retrieved with this action is billable. For more information, see <a href="https://aws.amazon.com/kinesis/video-streams/pricing/">Kinesis
        /// Video Streams pricing</a>.
        /// </para>
        ///  </li> </ul> </li> </ol> <note> 
        /// <para>
        /// The following restrictions apply to HLS sessions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A streaming session URL should not be shared between players. The service might throttle
        /// a session if multiple media players are sharing it. For connection limits, see <a
        /// href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/limits.html">Kinesis
        /// Video Streams Limits</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A Kinesis video stream can have a maximum of five active HLS streaming sessions. If
        /// a new session is created when the maximum number of sessions is already active, the
        /// oldest (earliest created) session is closed. The number of active <code>GetMedia</code>
        /// connections on a Kinesis video stream does not count against this limit, and the number
        /// of active HLS sessions does not count against the active <code>GetMedia</code> connection
        /// limit.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// You can monitor the amount of data that the media player consumes by monitoring the
        /// <code>GetMP4MediaFragment.OutgoingBytes</code> Amazon CloudWatch metric. For information
        /// about using CloudWatch to monitor Kinesis Video Streams, see <a href="http://docs.aws.amazon.com/kinesisvideostreams/latest/dg/monitoring.html">Monitoring
        /// Kinesis Video Streams</a>. For pricing information, see <a href="https://aws.amazon.com/kinesis/video-streams/pricing/">Amazon
        /// Kinesis Video Streams Pricing</a> and <a href="https://aws.amazon.com/pricing/">AWS
        /// Pricing</a>. Charges for both HLS sessions and outgoing AWS data apply.
        /// </para>
        ///  
        /// <para>
        /// For more information about HLS, see <a href="https://developer.apple.com/streaming/">HTTP
        /// Live Streaming</a> on the <a href="https://developer.apple.com">Apple Developer site</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHLSStreamingSessionURL service method.</param>
        /// 
        /// <returns>The response from the GetHLSStreamingSessionURL service method, as returned by KinesisVideoArchivedMedia.</returns>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidCodecPrivateDataException">
        /// The codec private data in at least one of the tracks of the video stream is not valid
        /// for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.MissingCodecPrivateDataException">
        /// No codec private data was found in at least one of tracks of the video stream.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NoDataRetentionException">
        /// A <code>PlaybackMode</code> of <code>ON_DEMAND</code> was requested for a stream that
        /// does not retain data (that is, has a <code>DataRetentionInHours</code> of 0).
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NotAuthorizedException">
        /// Status Code: 403, The caller is not authorized to perform an operation on the given
        /// stream, or the token has expired.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ResourceNotFoundException">
        /// <code>GetMedia</code> throws this error when Kinesis Video Streams can't find the
        /// stream that you specified.
        /// 
        ///  
        /// <para>
        ///  <code>GetHLSStreamingSessionURL</code> throws this error if a session with a <code>PlaybackMode</code>
        /// of <code>ON_DEMAND</code> is requested for a stream that has no fragments within the
        /// requested time range, or if a session with a <code>PlaybackMode</code> of <code>LIVE</code>
        /// is requested for a stream that has no fragments within the last 30 seconds.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.UnsupportedStreamMediaTypeException">
        /// The type of the media (for example, h.264 video or ACC audio) could not be determined
        /// from the codec IDs of the tracks in the first fragment for a playback session. The
        /// codec ID for track 1 should be <code>V_MPEG/ISO/AVC</code> and, optionally, the codec
        /// ID for track 2 should be <code>A_AAC</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/GetHLSStreamingSessionURL">REST API Reference for GetHLSStreamingSessionURL Operation</seealso>
        GetHLSStreamingSessionURLResponse GetHLSStreamingSessionURL(GetHLSStreamingSessionURLRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetHLSStreamingSessionURL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHLSStreamingSessionURL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/GetHLSStreamingSessionURL">REST API Reference for GetHLSStreamingSessionURL Operation</seealso>
        Task<GetHLSStreamingSessionURLResponse> GetHLSStreamingSessionURLAsync(GetHLSStreamingSessionURLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMediaForFragmentList


        /// <summary>
        /// Gets media for a list of fragments (specified by fragment number) from the archived
        /// data in an Amazon Kinesis video stream.
        /// 
        ///  <note> 
        /// <para>
        /// You must first call the <code>GetDataEndpoint</code> API to get an endpoint. Then
        /// send the <code>GetMediaForFragmentList</code> requests to this endpoint using the
        /// <a href="https://docs.aws.amazon.com/cli/latest/reference/">--endpoint-url parameter</a>.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// The following limits apply when using the <code>GetMediaForFragmentList</code> API:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A client can call <code>GetMediaForFragmentList</code> up to five times per second
        /// per stream. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Kinesis Video Streams sends media data at a rate of up to 25 megabytes per second
        /// (or 200 megabits per second) during a <code>GetMediaForFragmentList</code> session.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMediaForFragmentList service method.</param>
        /// 
        /// <returns>The response from the GetMediaForFragmentList service method, as returned by KinesisVideoArchivedMedia.</returns>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NotAuthorizedException">
        /// Status Code: 403, The caller is not authorized to perform an operation on the given
        /// stream, or the token has expired.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ResourceNotFoundException">
        /// <code>GetMedia</code> throws this error when Kinesis Video Streams can't find the
        /// stream that you specified.
        /// 
        ///  
        /// <para>
        ///  <code>GetHLSStreamingSessionURL</code> throws this error if a session with a <code>PlaybackMode</code>
        /// of <code>ON_DEMAND</code> is requested for a stream that has no fragments within the
        /// requested time range, or if a session with a <code>PlaybackMode</code> of <code>LIVE</code>
        /// is requested for a stream that has no fragments within the last 30 seconds.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/GetMediaForFragmentList">REST API Reference for GetMediaForFragmentList Operation</seealso>
        GetMediaForFragmentListResponse GetMediaForFragmentList(GetMediaForFragmentListRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetMediaForFragmentList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMediaForFragmentList operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/GetMediaForFragmentList">REST API Reference for GetMediaForFragmentList Operation</seealso>
        Task<GetMediaForFragmentListResponse> GetMediaForFragmentListAsync(GetMediaForFragmentListRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFragments


        /// <summary>
        /// Returns a list of <a>Fragment</a> objects from the specified stream and timestamp
        /// range within the archived data.
        /// 
        ///  
        /// <para>
        /// Listing fragments is eventually consistent. This means that even if the producer receives
        /// an acknowledgment that a fragment is persisted, the result might not be returned immediately
        /// from a request to <code>ListFragments</code>. However, results are typically available
        /// in less than one second.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must first call the <code>GetDataEndpoint</code> API to get an endpoint. Then
        /// send the <code>ListFragments</code> requests to this endpoint using the <a href="https://docs.aws.amazon.com/cli/latest/reference/">--endpoint-url
        /// parameter</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFragments service method.</param>
        /// 
        /// <returns>The response from the ListFragments service method, as returned by KinesisVideoArchivedMedia.</returns>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.NotAuthorizedException">
        /// Status Code: 403, The caller is not authorized to perform an operation on the given
        /// stream, or the token has expired.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoArchivedMedia.Model.ResourceNotFoundException">
        /// <code>GetMedia</code> throws this error when Kinesis Video Streams can't find the
        /// stream that you specified.
        /// 
        ///  
        /// <para>
        ///  <code>GetHLSStreamingSessionURL</code> throws this error if a session with a <code>PlaybackMode</code>
        /// of <code>ON_DEMAND</code> is requested for a stream that has no fragments within the
        /// requested time range, or if a session with a <code>PlaybackMode</code> of <code>LIVE</code>
        /// is requested for a stream that has no fragments within the last 30 seconds.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/ListFragments">REST API Reference for ListFragments Operation</seealso>
        ListFragmentsResponse ListFragments(ListFragmentsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListFragments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFragments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/ListFragments">REST API Reference for ListFragments Operation</seealso>
        Task<ListFragmentsResponse> ListFragmentsAsync(ListFragmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}