/*
 * Developer: Milad Raeisi [ miladsoft@yahoo.com ] [ My Telegram Account: https://t.me/miladsoft ]
 * 
 * Github source: https://github.com/miladsoft/InstagramGraphApi
 * Nuget package: https://www.nuget.org/packages/Miladsoft.InstagramGraphApi/
 * 
 */
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramGraphApi.Entity
{
    public class EdgeOwnerToTimelineMedia
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("page_info")]
        public PageInfo PageInfo { get; set; }

        [JsonProperty("edges")]
        public List<EdgeOwnerToTimelineMediaEdges> Edges { get; set; }
    }

    public class EdgeOwnerToTimelineMediaEdges
    {
        [JsonProperty("node")]
        public EdgeOwnerToTimelineMediaNode Node { get; set; }
    }

    public class EdgeOwnerToTimelineMediaNode
    {
        [JsonProperty("__typename")]
        public string Typename { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonProperty("display_url")]
        public string DisplayUrl { get; set; }

        [JsonProperty("display_resources")]
        public List<DisplayResource> DisplayResources { get; set; }

        [JsonProperty("dash_info")]
        public DashInfo DashInfo { get; set; }

        [JsonProperty("is_video")]
        public bool IsVideo { get; set; }

        [JsonProperty("video_url")]
        public string VideoUrl { get; set; }

        [JsonProperty("video_view_count")]
        public int VideoViewCount { get; set; }

        [JsonProperty("video_duration")]
        public double VideoDuration { get; set; }

        [JsonProperty("should_log_client_event")]
        public bool ShouldLogClientEvent { get; set; }

        [JsonProperty("tracking_token")]
        public string TrackingToken { get; set; }
        
        [JsonProperty("accessibility_caption")]
        public string AccessibilityCaption { get; set; }
        
        [JsonProperty("shortcode")]
        public string Shortcode { get; set; }
        
        [JsonProperty("comments_disabled")]
        public bool CommentsDisabled { get; set; }

        [JsonProperty("taken_at_timestamp")]
        public int TakenAtTimestamp { get; set; }
        
        [JsonProperty("gating_info")]
        public object GatingInfo { get; set; }

        [JsonProperty("media_preview")]
        public string MediaPreview { get; set; }

        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("is_published")]
        public bool? IsPublished { get; set; }

        [JsonProperty("owner")]
        public Owner Owner { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("viewer_has_liked")]
        public bool ViewerHasLiked { get; set; }

        [JsonProperty("viewer_has_saved")]
        public bool ViewerHasSaved { get; set; }

        [JsonProperty("viewer_has_saved_to_collection")]
        public bool ViewerHasSavedToCollection { get; set; }

        [JsonProperty("viewer_in_photo_of_you")]
        public bool ViewerInPhotoOfYou { get; set; }

        [JsonProperty("viewer_can_reshare")]
        public bool ViewerCanReshare { get; set; }

        [JsonProperty("caption_is_edited")]
        public bool? CaptionIsEdited { get; set; }

        [JsonProperty("has_ranked_comments")]
        public bool? HasRankedComments { get; set; }

        [JsonProperty("is_ad")]
        public bool? IsAd { get; set; }

        [JsonProperty("thumbnail_src")]
        public string ThumbnailSrc { get; set; }

        [JsonProperty("thumbnail_resources")]
        public List<ThumbnailResource> ThumbnailResources { get; set; }
        
        [JsonProperty("edge_media_to_comment")]
        public EdgeMediaToComment EdgeMediaToComment { get; set; }

        [JsonProperty("edge_media_to_caption")]
        public EdgeMediaToCaption EdgeMediaToCaption { get; set; }

        [JsonProperty("edge_media_to_tagged_user")]
        public EdgeMediaToTaggedUser EdgeMediaToTaggedUser { get; set; }

        [JsonProperty("edge_liked_by")]
        public EdgeLikedBy EdgeLikedBy { get; set; }

        [JsonProperty("edge_media_preview_like")]
        public EdgeMediaPreviewLike EdgeMediaPreviewLike { get; set; }

        [JsonProperty("edge_sidecar_to_children")]
        public EdgeSidecarToChildren EdgeSidecarToChildren { get; set; }
    }
}
