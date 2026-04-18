using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Category
    {
        // Defining the DB structure for the categories table
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName  = "nvarchar(100)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string Icon { get; set; } = "";

        [Column(TypeName = "nvarchar(10)")]
        public string Type { get; set; } = "Expense"; // Can be expense/income but set to expense automatically
    }
}
