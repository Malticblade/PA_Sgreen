//Steven Green 11138407
//MIS220-320
//PA4

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGreen4_PA4
{
    public partial class frmPokedex : Form
    {
        String pokeName;
        String pokeType;
        int pokeHP;
        double pokeHeight;
        double pokeWeight;
        List<Pokemon> Pokedex = new List<Pokemon>();

        public class Pokemon
        {
            public string Name;
            public string Type;
            public int HP;
            public double Height;
            public double Weight;
        }

        public void AddPokemon(string name, string type, int hp, double height, double weight)
        {
            Pokemon pkman = new Pokemon
            {
                Name = name,
                Type = type,
                HP = hp,
                Height = height,
                Weight = weight
            };
            Pokedex.Add(pkman);
            int x = Pokedex.Count();
            label1.Text = (x + " out of 10");
        }

        public void ClearPokedex()
        {
            Pokedex = new List<Pokemon>();
            txtbxDisplay.Clear();
        }

        private void clearControls()
        {
            txtbxName.Clear();
            txtbxType.Clear();
            txtbxHP.Clear();
            txtbxHeight.Clear();
            txtbxWeight.Clear();
        }

        public frmPokedex()
        {

            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pokeName = txtbxName.Text;
            pokeType = txtbxType.Text;
            
            if (txtbxName.Text == "" || pokeName.Length < 3) // you dont need a method for this
            {
                MessageBox.Show("INVALID NAME");
                clearControls();
                txtbxName.Focus();
            }
            else if (txtbxType.Text == "") // you dont need a method for this
            {
                MessageBox.Show("INVALID TYPE");
                clearControls();
                txtbxName.Focus();
            }
            else
            {
                try
                {
                    pokeHP = int.Parse(txtbxHP.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter a valid number HP field.");
                    return;
                }
                try
                {
                    pokeHeight = double.Parse(txtbxHeight.Text);
                    while (pokeHeight < 0.001 || pokeHeight > 1000)
                    {
                        MessageBox.Show("Please enter a valid number for the height field. (Between 0.01 kg and 9000 kg)");
                        txtbxHeight.Focus();
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid number for the height and weight fields.");
                    return;
                }
                try
                {
                    pokeWeight = double.Parse(txtbxWeight.Text);
                    while (pokeWeight < 0.01 || pokeWeight > 9000)
                    {
                        MessageBox.Show("Please enter a valid number for the weight field. (Between 0.001 m and 1000 m)");
                        txtbxWeight.Focus();
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid number for the height and weight fields.");
                    return;
                }
                AddPokemon(pokeName, pokeType, pokeHP, pokeHeight, pokeWeight);
            }
            //clearControls();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int x = Pokedex.Count();
            for (int y = 0; y < x; y++)
            {
                string dName = Pokedex[y].Name;
                string dHP = Convert.ToString(Pokedex[y].HP);
                string dType = Pokedex[y].Type;
                string dWeight = Convert.ToString(Pokedex[y].Weight);
                string dHeight = Convert.ToString(Pokedex[y].Height);
                txtbxDisplay.Text +=("\rPokemon #" + y + "\n\tName: " + dName + "\n\tHP: " + dHP + "\n\tType: " + dType + "\n\tWeight" + dWeight + "\n\tHeight" + dHeight);
                 
            }
           //txtbxDisplay.Text = Pokedex.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lblHeight_Click(object sender, EventArgs e)
        {

        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxHP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxDisplay_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnName_Click(object sender, EventArgs e)
        {
            //http://www.codeproject.com/Tips/761275/How-to-Sort-a-List
            Pokedex.Sort(delegate(Pokemon x, Pokemon y)
            {
             return x.Name.CompareTo(y.Name);
            });
        }

        private void btnHP_Click(object sender, EventArgs e)
        {
            //http://www.codeproject.com/Tips/761275/How-to-Sort-a-List
            Pokedex.Sort(delegate (Pokemon x, Pokemon y)
            {
                return x.Height.CompareTo(y.Height);
            });
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            //http://www.codeproject.com/Tips/761275/How-to-Sort-a-List
            Pokedex.Sort(delegate (Pokemon x, Pokemon y)
            {
                return x.Height.CompareTo(y.Height);
            });
        }

        private void btnWeight_Click(object sender, EventArgs e)
        {
            //http://www.codeproject.com/Tips/761275/How-to-Sort-a-List
            Pokedex.Sort(delegate (Pokemon x, Pokemon y)
            {
                return x.Height.CompareTo(y.Height);
            });
        }

        private void btnHeight_Click(object sender, EventArgs e)
        {
            //http://www.codeproject.com/Tips/761275/How-to-Sort-a-List
            Pokedex.Sort(delegate (Pokemon x, Pokemon y)
            {
                return x.Height.CompareTo(y.Height);
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearPokedex();
        }

        private void linkTracker_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void toolTracker_Click(object sender, EventArgs e)
        {

        }
    }
}
