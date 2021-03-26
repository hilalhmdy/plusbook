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

        private List<List<string>> get_path(List<string> a)
        {
            List<List<string>> paths = new List<List<string>>();
            string liveNode;
            Profile aProf;
            List<Profile> friendList;
            List<string> friends, aCopy;

            aCopy = new List<string>(a);
            aCopy.Reverse();
            friends = new List<string>();

            liveNode = a.LastOrDefault();
            aProf = profile_list.getProfile(liveNode);
            friendList = aProf.getFriendList();

            foreach (var Friend in friendList)
            {
                friends.Add(Friend.getName());
            }
            friends.Sort();

            for (int i = 0; i < friends.Count; i++)
            {
                paths.Add(new List<string>());
                paths[i].Add(friends[i]);
                paths[i].AddRange(aCopy);
                paths[i].Reverse();
            }

            return paths;
        }

        private bool path_found(List<List<string>> a, string b)
        {
            foreach (var Path in a)
            {
                if (Path.LastOrDefault() == b)
                {
                    return true;
                }
            }

            return false;
        }

        private bool list_nodes_empty(List<List<string>> a)
        {
            if (a == null)
            {
                return true;
            }

            return a.Count == 0;
        }

        private void clean_paths(List<List<string>> a, List<string> b)
        {
            a.RemoveAll(Path => b.Contains(Path.LastOrDefault()));
        }

        private List<string> get_final_path(List<List<string>> a, string b)
        {
            foreach (var Path in a)
            {
                if (Path.LastOrDefault() == b)
                {
                    return Path;
                }
            }
            return new List<string>();
        }

        private string get_explore_friends_bfs(string a, string b)
        {
            List<List<string>> himp_solusi = new List<List<string>>();
            List<string> himp_checked = new List<string>();
            List<string> initial = new List<string>();
            string result = "===------------------------------------------\nEksplorasi teman dari " + a + " ke " + b + ":\n------------------------------------------===\n\n";
            result += "Nama akun: " + a + " dan " + b + "\n";

            initial.Add(a);
            himp_solusi.AddRange(get_path(initial));
            himp_checked.Add(a);

            while (!path_found(himp_solusi, b) && !list_nodes_empty(himp_solusi))
            {
                List<string> liveNode = himp_solusi.FirstOrDefault();

                List<List<string>> temp = get_path(liveNode);
                clean_paths(temp, himp_checked);
                himp_solusi.AddRange(temp);

                himp_checked.Add(liveNode.LastOrDefault());
                himp_solusi.Remove(liveNode);
            }

            if (path_found(himp_solusi, b))
            {
                List<string> final = get_final_path(himp_solusi, b);
                int degree = final.Count - 2;

                if (degree == 0)
                {
                    result += "0th-degree connection. Sudah teman\n";
                }
                else if (degree == 1)
                {
                    result += "1st-degree connection\n";
                }
                else if (degree == 2)
                {
                    result += "2nd-degree connection\n";
                }
                else if (degree == 3)
                {
                    result += "3rd-degree connection\n";
                }
                else
                {
                    result += degree + "th-degree connection\n";
                }

                for (int i = 0; i < final.Count; i++)
                {
                    if (i == 0)
                    {
                        result += final[i];
                    }
                    else
                    {
                        result += " → " + final[i];
                    }
                }

                return result += "\n";
            }
            else
            {
                return result += "Tidak ada jalur koneksi yang tersedia\nAnda harus memulai koneksi baru itu sendiri.";
            }
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
            if (bfs_radio.Checked)
            {
                string a = start_profile_dropdown.Text;
                string b = end_profile_dropdown.Text;
                if(!(a.Equals("") || b.Equals("")))
                {
                    result = get_explore_friends_bfs(a, b);
                }
            }
            result += "\n";
            result += get_friend_recommendations(start_profile_dropdown.Text);
            result_textbox.Text = result;
        }
    }
}
