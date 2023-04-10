using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cLoaded
{
    internal class FormLoader
    {

        // process to update combo box
        // will take the combobox as a parameter and then fill it for us
        public static void FillComboBox(ComboBox comboBox)
        {
            // create an empty dictionary right here
            Dictionary<string, string> combosource = new Dictionary<string, string>();
            NpgsqlDataReader reader = CRUD.ExecuteReader();
            while (reader.Read())
            {
                // create a dictionary and then pass it through to the combo box
                combosource.Add(
                    key: reader[0].ToString(),
                    value: reader[1].ToString());

            }

            // close the connection 
            reader.Close();
            // dispose of the reader as it can cause multiple open connections = A pain 
            reader.Dispose();
            // populate the combobox based on dictionary that was made
            comboBox.DataSource = new BindingSource(combosource, null);
            // highlight what should be shown in the form
            comboBox.DisplayMember = "Value";
            // The key position for when we want to map it in the db
            comboBox.ValueMember = "Key";
            // always ensure a selection
            comboBox.SelectedIndex= 0;
            // makes the drop down extend out
            comboBox.DropDownWidth = 300;
        }

        public static Tuple <string,string> ReturnComboSelection(ComboBox comboBox)
        {
            string key = ((KeyValuePair<string, string>)comboBox.SelectedItem).Key;
            string value = ((KeyValuePair<string, string>)comboBox.SelectedItem).Value;

            return Tuple.Create(key, value);
                
        }

   


    }
}
