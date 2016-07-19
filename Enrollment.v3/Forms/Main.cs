using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Enrollment.Controls;

namespace Enrollment.Forms
{
    public partial class Main : RadForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void LoadEvent(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            pgAdmHome.Item.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;
            pgUserHome.Item.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;
            pgBuildingHome.Item.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;
            pgMaintenanceHome.Item.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;
            pgPaymentHome.Item.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;
            pgReportHome.Item.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;
            pgSectionHome.Item.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;
            pgTeacherHome.Item.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;

            pgNewStudentRecord.Item.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;
            pgEnlistment.Item.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;
            pgPayment.Item.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;
            pgLogsHome.Item.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;
            pgStaffHome.Item.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;
        }

        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        

        private void radMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void SelectedPageChangingEvent(object sender, Telerik.WinControls.UI.RadPageViewCancelEventArgs e)
        {
            if (
                e.Page == pgAdmHome         ||
                e.Page == pgBuildingHome    ||
                e.Page == pgMaintenanceHome ||
                e.Page == pgPaymentHome     ||
                e.Page == pgReportHome      ||
                e.Page == pgSectionHome     ||
                e.Page == pgTeacherHome     ||
                e.Page == pgUserHome        ||

                e.Page == pgNewStudentRecord ||
                e.Page == pgEnlistment ||
                e.Page == pgPayment ||
                e.Page == pgLogsHome || 
                e.Page == pgStaffHome
                )
            {
                e.Page.Item.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;
            }
            else
            {
                e.Page.Item.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Visible;
            }
        }

        private void CreateUserAction(object sender, EventArgs e)
        {
            //RadPageViewPage createUserPage = new RadPageViewPage();
            //createUserPage.Text = "Create New User";

            CreateUser createUser = new CreateUser();
            createUser.Text = "Create New User";
            createUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;

            //createUserPage.Controls.Add(createUser);

            usersPage.Pages.Add(createUser);
            usersPage.SelectedPage = createUser;

        }

        private void CreateTeacherAction(object sender, EventArgs e)
        {
            RadPageViewPage createTeacherPage = new RadPageViewPage();
            createTeacherPage.Text = "Create Teacher";

            CreateTeacher createTeacher = new CreateTeacher();
            createTeacher.Text = "Create Teacher";
            createTeacher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;

            createTeacherPage.Controls.Add(createTeacher);

            teachersPage.Pages.Add(createTeacherPage);
            teachersPage.SelectedPage = createTeacherPage;
        }



        private void MyAccountAction(object sender, EventArgs e)
        {
            adminPageView.SelectedPage = pageAdmHome;
        }

        private void StaffPageViewPageChanging(object sender, RadPageViewCancelEventArgs e)
        {
            if(e.Page == pageEnrollment)
            {
                RadPageViewPage createStudentPage = new RadPageViewPage();
                createStudentPage.Text = "Create New User";

                CreateStudent createStudent = new CreateStudent();
                createStudent.Text = "Create New User";
                createStudent.Dock = DockStyle.Fill;

                createStudentPage.Controls.Add(createStudent);

                enrollmentPage.Pages.Add(createStudentPage);
                enrollmentPage.SelectedPage = createStudentPage;
            }
            else if(e.Page == pageEnlistment)
            {
                /*
                RadPageViewPage enlistPage = new RadPageViewPage();
                enlistPage.Text = "Student Enlistment";

                CreateEnlistment createEnlistment = new CreateEnlistment();
                createEnlistment.Text = "Student Enlistment";
                createEnlistment.Dock = DockStyle.Fill;

                enlistPage.Controls.Add(createEnlistment);

                enlistmentPage.Pages.Add(enlistPage);
                enlistmentPage.SelectedPage = enlistPage;
                */
            }
        }
    }
}
