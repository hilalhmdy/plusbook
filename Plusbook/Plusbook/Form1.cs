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
        private void populate_profile_list(string[] lines)
        {

            int num_rel = Int32.Parse(lines[0]);
            for (int i=0; i<num_rel; i++)
            {
                string[] temp = lines[i + 1].Split(' ');
                profile_list.addConnection(temp[0], temp[1]);
                profile_list.addFriendshipList(temp[0], temp[1]);
            }

            /*
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
            */
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
        private string get_friend_recommendations(string a)
        {
            if (a=="")
            {
                return "";
            }
            string s = "===------------------------------------------\nRekomendasi teman untuk "+a+":\n------------------------------------------===\n\n";
            Profile A = profile_list.getProfile(a);
            List<Profile> friends_a = A.getFriendList();
            List<Profile> selected_tracker = new List<Profile>();
            foreach (Profile b in friends_a)
            {
                List<Profile> friends_b = b.getFriendList();
                foreach (Profile c in friends_b)
                {
                    Profile selected = null;
                    if (!(c.Equals(A)) && !(friends_a.Contains(c)))
                    {
                        selected = c;
                    }
                    if (selected != null && !(selected_tracker.Contains(selected)))
                    {
                        selected_tracker.Add(selected);
                        List<Profile> friends_sel = new List<Profile>();
                        foreach (Profile d in selected.getFriendList())
                        {
                            if (friends_a.Contains(d))
                            {
                                friends_sel.Add(d);
                            }
                        }
                        int n_mutual = friends_sel.Count;
                        s = s + selected.getName() + ": " + n_mutual.ToString() + " mutual friends\n";
                        foreach (Profile m in friends_sel)
                        {
                            s = s + " - " + m.getName() + "\n";
                        }
                        s += "\n";

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
                string[] lines = File.ReadAllLines(path);
                populate_profile_list(lines);
                fill_dropdowns();
                draw_graph();
                

            }
        }

        private void process_button_Click(object sender, EventArgs e)
        {

            string result = "";
            result += get_friend_recommendations(start_profile_dropdown.Text);
            result_textbox.Text = result;
        }
    }
}
