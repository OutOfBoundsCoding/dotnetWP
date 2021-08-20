using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetWp.Models
{    
    [Table("wp_term_relationships")]
    public class TermRelationship
    {
    [Key]
    [Column("object_id")]
    public int ObjectId { get; set; }
    [Column("term_taxonomy_id")]
    public int TaxonomyId { get; set; }
    [Column("term_order")]
    public int Order { get; set; }
    }
}
