using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Plusbook
{
    public partial class plusbook_form : Form
    {
        //PRIVATE VARS
        private ProfileList profile_list;
        private OpenFileDialog ofd;
        private string path;


        // PUBLIC
        public plusbook_form()
        {
            // INIT
            InitializeComponent();
            profile_list = new ProfileList();
            ofd = new OpenFileDialog();
            path = "";
            // END INIT



        }

        // helper method
        private void populate_profile_list(string raw_string)
        {
            char[] delims = { ' ', '\r', '\n' };
            string[] d_arr = raw_string.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            while (i < d_arr.Length)
            {
                if (i % 2 == 1)
                {
                    profile_list.addConnection(d_arr[i - 1], d_arr[i]);
                    profile_list.addFriendshipList(d_arr[i - 1], d_arr[i]);
                }
                i++;
            }
        }
        private void fill_dropdowns()
        {
            foreach (var p in profile_list.getProfiles())
            {
                start_profile_dropdown.Items.Add(p.getName());
                end_profile_dropdown.Items.Add(p.getName());
            }
        }
        private void draw_graph()
        {
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 
            foreach(var friendship in profile_list.getFriendshipList())
            {
                var E = graph.AddEdge(friendship[0], friendship[1]);
                E.Attr.ArrowheadAtTarget = Microsoft.Msagl.Drawing.ArrowStyle.None;
                E.Attr.ArrowheadAtSource = Microsoft.Msagl.Drawing.ArrowStyle.None;
            }
            //bind the graph to the viewer 
            graph_viewer.Graph = graph;

        }
        private string get_friend_recommendations(string a, string b)
        {
            if (a=="" || b == "")
            {
                return "";
            }
            string s = "Rekomendasi teman untuk "+a+":\n";
            Profile A = profile_list.getProfile(a);
            Profile B = profile_list.getProfile(b);
            foreach (var friend_a in A.getFriendList())
            {
                foreach (var friend_b in B.getFriendList())
                {
                    if ( !(friend_a.getName().Equals(b) || friend_b.getName().Equals(a)))
                    {
                        if (friend_a.getName().Equals(friend_b.getName()))
                        {
                            s = s + " - " + friend_b.getName() + "\n";
                        }
                    }
                }
            }
            return s;
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selected_filename_label.Text = ofd.SafeFileName;
                path = ofd.FileName;
                StreamReader stream = new StreamReader(path);
                string raw_string = stream.ReadToEnd().ToString();
                populate_profile_list(raw_string);
                fill_dropdowns();
                draw_graph();
                

            }
        }

        private void process_button_Click(object sender, EventArgs e)
        {
            string result = "";
            result += get_friend_recommendations(start_profile_dropdown.Text, end_profile_dropdown.Text);
        }
    }
}
