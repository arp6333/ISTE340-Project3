using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Ellie Parobek
 * Project 3
 * Client Programming
 **/
namespace P3
{
    /**
     * Retrieve and display info from RIT IST department API. 
     **/
    public partial class Form1 : Form
    {
        public List<int> visited = new List<int>();
        /**
         * Initialize tabs. 
         **/
        public Form1()
        {
            InitializeComponent();
            About();
            visited.Add(0);
            this.Text = "Ellie Parobek Project 3";
        }

        /**
         * Get the data from the API. 
         **/
        string getRESTData(string url)
        {
            const string baseUri = "http://ist.rit.edu/api";
            // Connect to the API
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUri + url);
            try
            {
                // Waits and gets the response from the REST request
                WebResponse response = request.GetResponse();
                // Using the response stream from the web request
                using (Stream responseStream = response.GetResponseStream())
                {
                    // Read the response from the api
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException we)
            {
                // Get the response
                Console.WriteLine("Error " + we);
                throw;
            }
        }

        /**
         * About tab. 
         **/
        public void About()
        {
            // Get About from the API
            string jsonAbout = getRESTData("/about/");
            About about = JToken.Parse(jsonAbout).ToObject<About>();

            tb_title.Text = about.title;
            tb_aboutDesc.Text = about.description;
            tb_aboutQuote.Text = about.quote;
            lbl_quoteAuthor.Text = about.quoteAuthor;
        }

        /**
         * Degrees tab. 
         **/
        public void Degrees()
        {
            // Get Degrees from the API
            string jsonDegrees = getRESTData("/degrees/");
            Degrees degrees = JToken.Parse(jsonDegrees).ToObject<Degrees>();

            // Undergraduate Degrees
            foreach (Undergraduate degree in degrees.undergraduate)
            {
                rtbUndergrad.Text += degree.title + " - " + degree.degreeName + Environment.NewLine;
                rtbUndergrad.Text += degree.description + Environment.NewLine;
                rtbUndergrad.Text += "Concentrations:" + Environment.NewLine;
                foreach (String conc in degree.concentrations)
                {
                    rtbUndergrad.Text += conc + Environment.NewLine;
                }
                rtbUndergrad.Text += Environment.NewLine;
            }

            // Gradute Degrees
            foreach (Graduate degreeGrad in degrees.graduate)
            {
                // Certificates
                if (degreeGrad.degreeName == "graduate advanced certificates")
                {
                    rtbGrad.Text += "Graduate Advanced Certificates:" + Environment.NewLine;
                    foreach (String cert in degreeGrad.availableCertificates)
                    {
                        rtbGrad.Text += cert + Environment.NewLine;
                    }
                }
                else
                {
                    rtbGrad.Text += degreeGrad.title + " - " + degreeGrad.degreeName + Environment.NewLine;
                    rtbGrad.Text += degreeGrad.description + Environment.NewLine;
                    // Concentrations (have to check if it has none)
                    try
                    {
                        rtbGrad.Text += "Concentrations:" + Environment.NewLine;
                        foreach (String concGrad in degreeGrad.concentrations)
                        {
                            rtbGrad.Text += concGrad + Environment.NewLine;
                        }
                    }
                    catch (NullReferenceException)
                    {
                        // If it has no concentrations
                        rtbGrad.Text += "None" + Environment.NewLine;
                    }
                    rtbGrad.Text += Environment.NewLine;
                }
            }
        }

        /**
         * Minors tab. 
         **/
        public void Minors()
        {
            // Get Minors from the API
            string jsonMinors = getRESTData("/minors/");
            Minors minors = JToken.Parse(jsonMinors).ToObject<Minors>();

            foreach (UgMinor minor in minors.UgMinors)
            {
                rtbMinors.Text += minor.title + " - " + minor.name + Environment.NewLine;
                rtbMinors.Text += minor.description + Environment.NewLine;
                rtbMinors.Text += "Courses:" + Environment.NewLine;
                foreach (String cour in minor.courses)
                {
                    rtbMinors.Text += cour + ", ";
                }
                rtbMinors.Text += "Note:" + Environment.NewLine;
                rtbMinors.Text += minor.note + Environment.NewLine;
                rtbMinors.Text += Environment.NewLine;
            }
        }

        /**
         * Employment tab. 
         **/
        public void Employment()
        {
            button5.PerformClick();
            button1.PerformClick();

        }
        // Map button
        private void button17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ist.rit.edu/api/map.php");
        }
        // CoopInformation table button
        private void button5_Click(object sender, EventArgs e)
        {
            // Get Employment from the API
            string jsonEmployment = getRESTData("/employment/");
            Employment employment = JToken.Parse(jsonEmployment).ToObject<Employment>();
            tbIntroTitle.Text = employment.introduction.title;

            DataTable table = new DataTable();

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(CoopInformation));
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (CoopInformation item in employment.coopTable.coopInformation)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }

            dataGridView1.DataSource = table;
        }
        // ProfessionalEmploymentInformation table button
        private void button6_Click(object sender, EventArgs e)
        {
            // Get Employment from the API
            string jsonEmployment = getRESTData("/employment/");
            Employment employment = JToken.Parse(jsonEmployment).ToObject<Employment>();
            tbIntroTitle.Text = employment.introduction.title;

            DataTable table = new DataTable();

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(ProfessionalEmploymentInformation));
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (ProfessionalEmploymentInformation item in employment.employmentTable.professionalEmploymentInformation)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }

            dataGridView1.DataSource = table;
        }
        // Introduction button
        private void button1_Click(object sender, EventArgs e)
        {
            rtbContent.Text = "";
            // Get Employment from the API
            string jsonEmployment = getRESTData("/employment/");
            Employment employment = JToken.Parse(jsonEmployment).ToObject<Employment>();
            foreach (Content con in employment.introduction.content)
            {
                rtbContent.Text += con.title + ":" + Environment.NewLine;
                rtbContent.Text += con.description + Environment.NewLine + Environment.NewLine;
            }
        }
        // Degree Statistics button
        private void button2_Click(object sender, EventArgs e)
        {
            rtbContent.Text = "";
            // Get Employment from the API
            string jsonEmployment = getRESTData("/employment/");
            Employment employment = JToken.Parse(jsonEmployment).ToObject<Employment>();
            foreach (Statistic stat in employment.degreeStatistics.statistics)
            {
                rtbContent.Text += stat.value + " ";
                rtbContent.Text += stat.description + Environment.NewLine + Environment.NewLine;
            }
        }
        // Employers button
        private void button3_Click(object sender, EventArgs e)
        {
            rtbContent.Text = "";
            // Get Employment from the API
            string jsonEmployment = getRESTData("/employment/");
            Employment employment = JToken.Parse(jsonEmployment).ToObject<Employment>();
            foreach (String emp in employment.employers.employerNames)
            {
                rtbContent.Text += emp + Environment.NewLine;
            }
        }
        // Careers button
        private void button4_Click(object sender, EventArgs e)
        {
            rtbContent.Text = "";
            // Get Employment from the API
            string jsonEmployment = getRESTData("/employment/");
            Employment employment = JToken.Parse(jsonEmployment).ToObject<Employment>();
            foreach (String car in employment.careers.careerNames)
            {
                rtbContent.Text += car + Environment.NewLine;
            }
        }

        /**
        * People tab. 
        **/
        private void People()
        {
            button7.PerformClick();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        // Load faculty
        private void button7_Click(object sender, EventArgs e)
        {
            // Get People from the API
            string jsonPeople = getRESTData("/people/");
            People people = JToken.Parse(jsonPeople).ToObject<People>();

            listBox1.Items.Clear();
            foreach (Faculty fac in people.faculty)
            {
                listBox1.Items.Add(fac.name);
            }
        }
        // Load staff
        private void button8_Click(object sender, EventArgs e)
        {
            // Get People from the API
            string jsonPeople = getRESTData("/people/");
            People people = JToken.Parse(jsonPeople).ToObject<People>();

            listBox1.Items.Clear();
            foreach (Staff staff in people.staff)
            {
                listBox1.Items.Add(staff.name);
            }
        }
        // Get the selected faculty member
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get People from the API
            string jsonPeople = getRESTData("/people/");
            People people = JToken.Parse(jsonPeople).ToObject<People>();

            rtbPeople.Text = "";
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            // Get the info for selected member
            foreach (Faculty fac in people.faculty)
            {
                if (fac.name == text)
                {
                    pictureBox1.Load(fac.imagePath);
                    foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(fac))
                    {
                        string name = descriptor.Name;
                        object value = descriptor.GetValue(fac);
                        rtbPeople.Text += name + ": " + value + Environment.NewLine;
                    }
                }
            }
            foreach (Staff staff in people.staff)
            {
                if (staff.name == text)
                {
                    pictureBox1.Load(staff.imagePath);
                    foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(staff))
                    {
                        string name = descriptor.Name;
                        object value = descriptor.GetValue(staff);
                        rtbPeople.Text += name + ": " + value + Environment.NewLine;
                    }
                }
            }
        }

        /**
         * Research tab. 
         **/
        public void Research()
        {
            button9.PerformClick();
        }
        // Sort by Interest Area button
        private void button9_Click(object sender, EventArgs e)
        {
            // Get Research from the API
            string jsonResearch = getRESTData("/research/");
            Research research = JToken.Parse(jsonResearch).ToObject<Research>();

            listBox2.Items.Clear();
            foreach (ByInterestArea area in research.byInterestArea)
            {
                listBox2.Items.Add(area.areaName);
            }
        }
        // Sort by Faculty button
        private void button10_Click(object sender, EventArgs e)
        {
            // Get Research from the API
            string jsonResearch = getRESTData("/research/");
            Research research = JToken.Parse(jsonResearch).ToObject<Research>();

            listBox2.Items.Clear();
            foreach (ByFaculty fac in research.byFaculty)
            {
                listBox2.Items.Add(fac.facultyName + " - " + fac.username);
            }
        }
        // Get the selected research
        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Get People from the API
            string jsonResearch = getRESTData("/research/");
            Research research = JToken.Parse(jsonResearch).ToObject<Research>();

            rtbResearch.Text = "";
            string text = listBox2.GetItemText(listBox2.SelectedItem);
            foreach (ByFaculty fac in research.byFaculty)
            {
                if ((fac.facultyName + " - " + fac.username) == text)
                {
                    foreach (String value in fac.citations)
                    {
                        rtbResearch.Text += value + Environment.NewLine;
                    }
                }
            }
            foreach (ByInterestArea area in research.byInterestArea)
            {
                if (area.areaName == text)
                {
                    foreach (String value in area.citations)
                    {
                        rtbResearch.Text += value + Environment.NewLine;
                    }
                }
            }
        }

        /**
         * Resources tab. 
         **/
        public void Resources()
        {
            // Get Resources from the API
            string jsonResources = getRESTData("/resources/");
            Resources resources = JToken.Parse(jsonResources).ToObject<Resources>();

            tbTitle.Text = resources.title;
            tbSubtitle.Text = resources.subTitle;
            button11.PerformClick();
        }
        // Study Abroad button
        private void button11_Click(object sender, EventArgs e)
        {
            // Get Resources from the API
            string jsonResources = getRESTData("/resources/");
            Resources resources = JToken.Parse(jsonResources).ToObject<Resources>();

            rtbResources.Text = "";
            rtbResources.Text += resources.studyAbroad.title + Environment.NewLine + resources.studyAbroad.description + Environment.NewLine + Environment.NewLine;
            foreach (Place place in resources.studyAbroad.places)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(place))
                {
                    string name = descriptor.Name;
                    object value = descriptor.GetValue(place);
                    rtbResources.Text += value + Environment.NewLine + Environment.NewLine;
                }
            }
        }
        // Student Services button
        private void button12_Click(object sender, EventArgs e)
        {
            // Get Resources from the API
            string jsonResources = getRESTData("/resources/");
            Resources resources = JToken.Parse(jsonResources).ToObject<Resources>();

            rtbResources.Text = "";
            rtbResources.Text += resources.studentServices.title + Environment.NewLine;
            rtbResources.Text += resources.studentServices.academicAdvisors.title + ": " + Environment.NewLine + resources.studentServices.academicAdvisors.description + Environment.NewLine + Environment.NewLine;

            rtbResources.Text += resources.studentServices.professonalAdvisors.title + ": " + Environment.NewLine;
            foreach (AdvisorInformation info in resources.studentServices.professonalAdvisors.advisorInformation)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(info))
                {
                    string name = descriptor.Name;
                    object value = descriptor.GetValue(info);
                    rtbResources.Text += name + ": " + value + Environment.NewLine;
                }
                rtbResources.Text += Environment.NewLine;
            }
            
            rtbResources.Text += resources.studentServices.facultyAdvisors.title + ": " + Environment.NewLine + resources.studentServices.facultyAdvisors.description + Environment.NewLine + Environment.NewLine;

            rtbResources.Text += resources.studentServices.istMinorAdvising.title + ": " + Environment.NewLine;
            foreach (MinorAdvisorInformation info in resources.studentServices.istMinorAdvising.minorAdvisorInformation)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(info))
                {
                    string name = descriptor.Name;
                    object value = descriptor.GetValue(info);
                    rtbResources.Text += name + ": " + value + Environment.NewLine;
                }
                rtbResources.Text += Environment.NewLine;
            }
        }
        // Tutors and Lab Information button
        private void button13_Click(object sender, EventArgs e)
        {
            // Get Resources from the API
            string jsonResources = getRESTData("/resources/");
            Resources resources = JToken.Parse(jsonResources).ToObject<Resources>();

            rtbResources.Text = "";
            rtbResources.Text += resources.tutorsAndLabInformation.title + Environment.NewLine;
            rtbResources.Text += resources.tutorsAndLabInformation.description + Environment.NewLine + Environment.NewLine;
            rtbResources.Text += resources.tutorsAndLabInformation.tutoringLabHoursLink + Environment.NewLine;

        }
        // Student Ambassadors button
        private void button14_Click(object sender, EventArgs e)
        {
            // Get Resources from the API
            string jsonResources = getRESTData("/resources/");
            Resources resources = JToken.Parse(jsonResources).ToObject<Resources>();

            rtbResources.Text = "";
            rtbResources.Text += resources.studentAmbassadors.title + Environment.NewLine;
            foreach (SubSectionContent info in resources.studentAmbassadors.subSectionContent)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(info))
                {
                    object value = descriptor.GetValue(info);
                    rtbResources.Text += value + Environment.NewLine;
                }
                rtbResources.Text += Environment.NewLine;
            }
            rtbResources.Text += resources.studentAmbassadors.applicationFormLink + Environment.NewLine;
            rtbResources.Text += resources.studentAmbassadors.note;
        }
        // Forms button
        private void button15_Click(object sender, EventArgs e)
        {
            // Get Resources from the API
            string jsonResources = getRESTData("/resources/");
            Resources resources = JToken.Parse(jsonResources).ToObject<Resources>();

            rtbResources.Text = "Graduate Forms: " + Environment.NewLine;
            foreach (GraduateForm info in resources.forms.graduateForms)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(info))
                {
                    object value = descriptor.GetValue(info);
                    rtbResources.Text += value + Environment.NewLine;
                }
                rtbResources.Text += Environment.NewLine;
            }
            rtbResources.Text += "Undergraduate Forms: " + Environment.NewLine;
            foreach (UndergraduateForm info in resources.forms.undergraduateForms)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(info))
                {
                    object value = descriptor.GetValue(info);
                    rtbResources.Text += value + Environment.NewLine;
                }
                rtbResources.Text += Environment.NewLine;
            }
        }
        // Coop Enrollment button
        private void button16_Click(object sender, EventArgs e)
        {
            // Get Resources from the API
            string jsonResources = getRESTData("/resources/");
            Resources resources = JToken.Parse(jsonResources).ToObject<Resources>();

            rtbResources.Text = resources.coopEnrollment.title + Environment.NewLine;
            foreach (EnrollmentInformationContent info in resources.coopEnrollment.enrollmentInformationContent)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(info))
                {
                    object value = descriptor.GetValue(info);
                    rtbResources.Text += value + Environment.NewLine;
                }
                rtbResources.Text += Environment.NewLine;
            }
            rtbResources.Text += resources.coopEnrollment.RITJobZoneGuidelink;
        }

        /**
         * News tab. 
         **/
        public void News()
        {
            // Get News from the API
            string jsonNews = getRESTData("/news/");
            News news = JToken.Parse(jsonNews).ToObject<News>();
            
            foreach (Older theNews in news.older)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(theNews))
                {
                    object value = descriptor.GetValue(theNews);
                    rtbNews.Text += value + Environment.NewLine;
                }
                rtbNews.Text += Environment.NewLine;
            }
        }

        /**
         * Contact tab. 
         **/
        public void Contact()
        {
            webBrowser1.Navigate(new Uri("http://ist.rit.edu/api/contactForm.php"));
            // Hide the script error
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        /**
         * Load the desired tab when it is entered.  
         **/
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if tab has been visited to not reload
            if (visited.IndexOf(tabControl1.SelectedIndex) == -1)
            {
                visited.Add(tabControl1.SelectedIndex);
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        About();
                        break;
                    case 1:
                        Degrees();
                        break;
                    case 2:
                        Minors();
                        break;
                    case 3:
                        Employment();
                        break;
                    case 4:
                        People();
                        break;
                    case 5:
                        Research();
                        break;
                    case 6:
                        Resources();
                        break;
                    case 7:
                        News();
                        break;
                    case 8:
                        Contact();
                        break;
                }
            }
        }
    }
}