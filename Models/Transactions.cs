using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Transactions
    {
        // Defining the table structure of the transactions section
        [Key]
        public int TransactionId { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } // This is how the FK connection is made -- other ways possible
        
        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string? Note { get; set; } // Sets this to be a nullable string

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
