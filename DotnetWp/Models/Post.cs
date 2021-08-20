using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetWp.Models
{    
    [Table("wp_posts")]
    public class Post
    {
        [Key]
        [Column("ID")]
        public int Id {get; set;}
        [Column("post_author")]
        public int AuthorId {get; set;}
        [Column("post_date_gmt")]
        public DateTime DateGmt {get; set;}
        [Column("post_content")]
        public string Content {get; set;}
        [Column("post_title")]
        public string Title {get; set;}
        [Column("post_excerpt")]
        public string Excerpt {get; set;}
        [Column("post_status")]
        public string Status {get; set;}
        [Column("comment_status")]
        public DateTime CommentStatus {get; set;}
        [Column("ping_status")]
        public string PingStatus {get; set;}
        [Column("post_password")]
        public DateTime PostPassword {get; set;}
        [Column("post_name")]
        public string PostName {get; set;}
        [Column("to_ping")]
        public string ToPing {get; set;}
        [Column("pinged")]
        public string Pinged {get; set;}
        [Column("post_modified")]
        public DateTime PostModified {get; set;}
        [Column("post_modified_gmt")]
        public DateTime PostModifiedGmt {get; set;}
        [Column("post_content_filtered")]
        public string PostContentFiltered {get; set;}
        [Column("post_parent")]
        public string PostParent {get; set;}
        [Column("guid")]
        public string Guid {get; set;}
        [Column("menu_order")]
        public int MenuOrder {get; set;}
        [Column("post_type")]
        public string PostType {get; set;}
        [Column("post_mime_type")]
        public string PostMimeType {get; set;}
        [Column("comment_count")]
        public long CommentCount {get; set;}
    }
}
