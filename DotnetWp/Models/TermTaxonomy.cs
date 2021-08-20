using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetWp.Models
{    
    [Table("wp_term_taxonomy")]
    public class TermTaxonomy
    {
    [Key]
    [Column("term_id")]
    public int TermId { get; set; }
    [Column ("taxonomy")]
    public string Taxonomy { get; set; }
    [Column("description")]
    public string Description { get; set; }
    [Column("parent")]
    public int Parent { get; set; }
    [Column("count")]
    public int Count { get; set; }
    }
}
