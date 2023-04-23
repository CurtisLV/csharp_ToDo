using System.Data;

namespace csharp_ToDo
{
    public partial class ToDoListForm : Form
    {
        public ToDoListForm()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void ToDoListForm_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
