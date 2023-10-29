using RazorPages.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesZenSpaCh7.Models
{
    public class CilentService
    {
        [Key]
        public int ID {  get; set; }
        [ForeignKey("CilentID")]
        public int CilentID { get; set; }
        public Cilent? Cilent { get; set; }
        [ForeignKey("ServiceID")]
        public int ServiceID {  get; set; }
        public Services? Services { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }=DateTime.Now;

    }
}
