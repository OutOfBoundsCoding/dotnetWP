using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetWp.Models
{    
    [Table("wp_terms")]
    public class Term 
    {
    [Key]
    [Column("term_id")]
    public int TermId {get; set;}
    
    [Column("name")]
    public string Name {get; set;}
    [Column("slug")]
    public string Slug {get; set;}
    [Column("term_group")]
    public int TermGroup {get; set;}
    }
}
