using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Node_by_franck node = new Node_by_franck();
            string bidon = node.ShowStr();

            MessageBox.Show(bidon);
        }

        private void geToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Select a JSON File (NODE)";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    if ((myStream = openFileDialog.OpenFile() as FileStream) != null)
                    {
                        using (myStream)
                        {
                            var jsonFile = myStream.Name;
                            Node node = JsonConvert.DeserializeObject<Node>(File.ReadAllText(jsonFile));

                            var path = node.Serialize(node);
                            MessageBox.Show("The result is : " + path);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void returnNodeObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string value = "8631.2..4..7..9..";
            if (InputBox("Node representation", "Enter node representation:", ref value) == DialogResult.OK)
            {
                // POSITION : 0 = new node / 1 = left node / 2 = right node
                int node_position = 0;
                List<Node> nodes = new List<Node>();
                Node current_node = new Node();

                foreach (char c in value)
                {
                    if (c != '.')
                    {
                        Node new_node = new Node();
                        new_node.Number = (int)char.GetNumericValue(c);

                        switch (node_position)
                        {
                            case 1:
                                current_node.Left = new_node;
                                break;
                            case 2:
                                current_node.Right = new_node;
                                break;
                        }

                        current_node = new_node;

                        nodes.Add(new_node);
                    }

                    if (node_position == 2)
                    {
                        node_position = 0;
                    }
                    else
                    {
                        node_position++;
                    }
                }

                MessageBox.Show("Done!");
            }
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }
}
