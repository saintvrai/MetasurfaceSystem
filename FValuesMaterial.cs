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

namespace MySystem
{
    public partial class FValuesMaterial : Form
    {
        FAddNewMaterial addNewMaterial;

        public FValuesMaterial()
        {
            InitializeComponent();
            LoadMaterialsToListView(@"C:\CST_Files\Materials");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addNewMaterial = new FAddNewMaterial();
            addNewMaterial.ShowDialog();
            
            if(addNewMaterial.DialogResult == DialogResult.OK)
            //TODO: Спарсить несколько файлов из material libryary и добавить их в listview в этой форме
            {
                listBox1.Items.Add(Material.MaterialName);
                int i = 1;
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(Material.MaterialName);
                item.SubItems.Add(Material.Type);
                item.SubItems.Add(Material.ElectricalConductivity.ToString());
                listView1.Items.Add(item);
                i++;
            }
        }
        private void LoadMaterialsToListView(string folderPath)
        {
            DirectoryInfo d = new DirectoryInfo(folderPath);
            foreach (var file in d.GetFiles("*.txt"))
            {
                string fileName = file.Name;
                string type = "";

                using (StreamReader reader = new StreamReader(file.FullName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.StartsWith("Type"))
                        {
                            type = line.Substring(line.IndexOf("=") + 1).Trim();
                        }
                    }
                }

                ListViewItem item = new ListViewItem(new string[] { Path.GetFileNameWithoutExtension(file.Name) });
                item.SubItems.Add(type);
                item.SubItems.Add(folderPath);
                listView1.Items.Add(item);
            }
            
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string searchName = textBox1.Text; // get the search name from the TextBox
            //ListViewItem foundItem = listView1.FindItemWithText(searchName); // search for the item by its text property

            //if (foundItem != null) // check if the item was found
            //{
            //    foundItem.Selected = true; // select the found item
            //    listView1.Focus(); // set focus to the ListView to show the selected item
            //}
            //else
            //{
            //    MessageBox.Show("Item not found."); // display an error message if the item was not found
            //}
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //apply your search only when pressing ENTER key
            {
                string searchName = textBox1.Text; // get the search name from the TextBox
                ListViewItem foundItem = listView1.FindItemWithText(searchName); // search for the item by its text property
                if (foundItem != null) // check if the item was found
                {
                    listView1.EnsureVisible(foundItem.Index);
                    foundItem.Selected = true; // select the found item
                    listView1.Focus(); // set focus to the ListView to show the selected item

                }
                else
                {
                    MessageBox.Show("Item not found."); // display an error message if the item was not found
                }
            }
               
        }
    }
}
