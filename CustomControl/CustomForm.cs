namespace LTUD1_MF_BHX.CustomControl
{
    public abstract class CustomForm : Form
    {
        private CustomButton buttonCreate;
        private CustomButton buttonRead;
        private CustomButton buttonUpdate;
        private CustomButton buttonDelete;
        private CustomDataGridView dataGridView;


        // Cung cấp quyền truy cập cho CustomDataGridView và CustomButton
        public CustomButton ButtonCreate { get; protected set; }
        public CustomButton ButtonRead { get; protected set; }
        public CustomButton ButtonUpdate { get; protected set; }
        public CustomButton ButtonDelete { get; protected set; }
        public CustomDataGridView DataGridView { get; protected set; }

        public CustomForm()
        {

            buttonCreate = new CustomButton("Create", buttonCreate_Click!);
            buttonRead = new CustomButton("Read", buttonRead_Click!);
            buttonUpdate = new CustomButton("Update", buttonUpdate_Click!);
            buttonDelete = new CustomButton("Delete", buttonDelete_Click!);

            dataGridView = new CustomDataGridView();
            dataGridView.Dock = DockStyle.Fill;

            Controls.Add(buttonCreate);
            Controls.Add(buttonRead);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(dataGridView);
        }
        // Code for creating a record...
        protected abstract void buttonCreate_Click(object sender, EventArgs e);

        // Code for reading records...
        protected abstract void buttonRead_Click(object sender, EventArgs e);


        // Code for updating a record...
        protected abstract void buttonUpdate_Click(object sender, EventArgs e);


        // Code for deleting a record...
        protected abstract void buttonDelete_Click(object sender, EventArgs e);
    }
}
