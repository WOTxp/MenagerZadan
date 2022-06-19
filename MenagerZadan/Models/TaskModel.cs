using System.ComponentModel;

namespace MenagerZadan.Models
{
    public class TaskModel
    {
    public int TaskId { get; set; }
    [DisplayName("Nazwa")]

    public string Name { get; set; }
    [DisplayName("Opis")]

    public string Description { get; set; }

    public bool Done { get; set; }
    }
}
