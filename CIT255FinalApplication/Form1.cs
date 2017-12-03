using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIT255FinalApplication;
using static CIT255FinalApplication.Model.Enum;
using CIT255FinalApplication.Model;
using CIT255FinalApplication.Data;

namespace CIT255FinalApplication
{
    public partial class Form1 : Form
    {
        Model.Enum.AppState appState;
        BusinessLayer businessLayer = new BusinessLayer();

        public Form1()
        {
            InitializeComponent();
            HideAllButtons();
            ShowMainButtons();
            DisplayAllMovies();
        }

        #region View
        public void HideAllButtons()
        {
            btnAdd.Visible = false;
            btnQuery.Visible = false;
            btnUpdate.Visible = false;
            btnVoteDown.Visible = false;
            btnVoteUp.Visible = false;

            btnMainMenu.Visible = false;
            btnQueryByName.Visible = false;
            btnQueryByRating.Visible = false;
            btnQueryByGenre.Visible = false;
            btnExit.Visible = false;

            btnVote.Visible = false;
            btnDelete.Visible = false;
            btnContinue.Visible = false;

            lbID.Visible = false;
            lbName.Visible = false;
            lbYear.Visible = false;
            lbGenre.Visible = false;
            lbRating.Visible = false;

            txtID.Visible = false;
            txtName.Visible = false;
            txtYear.Visible = false;
            txtGenre.Visible = false;
            txtRating.Visible = false;

            txtID.Text = "";
            txtName.Text = "";
            txtYear.Text = "";
            txtGenre.Text = "";
            lstDisplayList.Items.Clear();
            
        }

        public void ShowMainButtons()
        {
            btnAdd.Visible = true;
            btnQuery.Visible = true;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnVote.Visible = true;
            btnExit.Visible = true;

            txtID.ReadOnly = false;
        }

        public void ShowQueryButtons()
        {
            btnMainMenu.Visible = true;
            btnQueryByName.Visible = true;
            btnQueryByRating.Visible = true;
            btnQueryByGenre.Visible = true;
            btnExit.Visible = true;
        }

        public void ShowVoteButtons()
        {
            btnVoteUp.Visible = true;
            btnVoteDown.Visible = true;
            btnExit.Visible = true;
            btnMainMenu.Visible = true;
        }

        public void ShowAddForm()
        {
            lbID.Visible = true;
            lbName.Visible = true;
            lbYear.Visible = true;
            lbGenre.Visible = true;

            txtID.Visible = true;
            txtName.Visible = true;
            txtYear.Visible = true;
            txtGenre.Visible = true;

            btnMainMenu.Visible = true;
            btnExit.Visible = true;
            btnContinue.Visible = true;

        }

        public void ShowDeleteForm()
        {
            lbID.Visible = true;
            txtID.Visible = true;

            btnMainMenu.Visible = true;
            btnExit.Visible = true;
            btnContinue.Visible = true;
        }
        #endregion

        #region Main Menu Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            appState = AppState.Add;
            HideAllButtons();
            ShowAddForm();
            DisplayAllMovies();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            appState = AppState.Delete;
            HideAllButtons();
            ShowDeleteForm();
            DisplayAllMovies();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstDisplayList.SelectedItem != null) {
                appState = AppState.Update;
                SetUpdateValues(GetMovieFromListBox());
            }
            else
            {
                MessageBox.Show("Please select an Movie above.");
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            HideAllButtons();
            ShowQueryButtons();
            DisplayAllMovies();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            appState = AppState.None;
            HideAllButtons();
            ShowMainButtons();
            DisplayAllMovies();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            switch (appState)
            {
                case AppState.None:
                    break;
                case AppState.Add:
                    AppStateAdd();
                    break;
                case AppState.Delete:
                    AppStateDelete();
                    break;
                case AppState.Update:
                    AppStateUpdate();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Vote Buttons

        private void btnVoteUp_Click(object sender, EventArgs e)
        {
            businessLayer.VoteUp(lstDisplayList.SelectedItem as Movie);
            lstDisplayList.Items.Clear();
            DisplayAllMovies();
        }

        private void btnVoteDown_Click(object sender, EventArgs e)
        {
            businessLayer.VoteDown(lstDisplayList.SelectedItem as Movie);
            lstDisplayList.Items.Clear();
            DisplayAllMovies();
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            HideAllButtons();
            ShowVoteButtons();
            DisplayAllMovies();
        }
        #endregion

        #region Query Buttons
        private void btnQueryByName_Click(object sender, EventArgs e)
        {

            lbName.Visible = true;
            txtName.Visible = true;

            if (txtName.Text != "")
            {
                DisplayQueriedMovies(businessLayer.QueryMoviesByName(txtName.Text));
                lbName.Visible = false;
                txtName.Visible = false;
                txtGenre.Text = "";
            }

        }

        private void btnQueryByType_Click(object sender, EventArgs e)
        {
            lbGenre.Visible = true;
            txtGenre.Visible = true;

            if (txtGenre.Text != "")
            {
                DisplayQueriedMovies(businessLayer.QueryMoviesByGenre(txtGenre.Text));
                lbGenre.Visible = false;
                txtGenre.Visible = false;
                txtGenre.Text = "";
            }
        }

        private void btnQueryByRating_Click(object sender, EventArgs e)
        {

            lbRating.Visible = true;
            txtRating.Visible = true;

            if (txtRating.Text != "")
            {
                int x = 0;
                int.TryParse(txtRating.Text, out x);
                DisplayQueriedMovies(businessLayer.QueryMoviesByRating(x));
                lbRating.Visible = false;
                txtRating.Visible = false;
                txtRating.Text = "";
            }
        }
        #endregion

        #region Button Methods
        public void DisplayAllMovies()
        {
            List<Movie> movies = businessLayer.DisplayAllMovies();

            foreach (Movie movie in movies)
            {
                lstDisplayList.Items.Add(movie);
            }
        }

        public void DisplayQueriedMovies(List<Movie> movies)
        {
            lstDisplayList.Items.Clear();
            foreach (Movie movie in movies)
            {
                lstDisplayList.Items.Add(movie);
            }
        }

        public Movie GetMovieFromUser()
        {
            Movie movie = new Movie();
            int ID;
            int Year;
            Int32.TryParse(txtID.Text, out ID);
            Int32.TryParse(txtYear.Text, out Year);

            movie.ID = ID;
            movie.Name = txtName.Text;
            movie.Year = Year;
            movie.Genre = txtGenre.Text;
            movie.UserRating = 0;

            return movie;
        }

        public Movie GetMovieFromListBox()
        {
            Movie movie = new Movie();
            movie = lstDisplayList.SelectedItem as Movie;

            return movie;
        }

        public void SetUpdateValues(Movie movie)
        {
            HideAllButtons();
            DisplayAllMovies();

            txtID.Text = movie.ID.ToString();
            txtName.Text = movie.Name;
            txtYear.Text = movie.Year.ToString();
            txtGenre.Text = movie.Genre;

            txtID.ReadOnly = true;

            ShowAddForm();

        }

        public void AppStateAdd()
        {
            Movie movie = GetMovieFromUser();
            if (movie.ID == 0)
            {
                MessageBox.Show("Please enter a valid number for the movie ID.");
            }

            if (movie.Name == "")
            {
                MessageBox.Show("Please enter a valid name for the movie.");
            }

            if (movie.Genre == "")
            {
                MessageBox.Show("Please enter a valid Genre for the movie.");
            }

            if (movie.Year == 0)
            {
                MessageBox.Show("Please enter a valid number for the movie year.");
            }
            
            if (movie.ID != 0 && movie.Name != "" && movie.Genre != "" && movie.Year != 0)
            {
                businessLayer.addMovie(movie);
                HideAllButtons();
                ShowMainButtons();
                DisplayAllMovies();
            }
        }

        public void AppStateDelete()
        {
            int ID;
            int.TryParse(txtID.Text, out ID);
            List<Movie> movies = businessLayer.QueryMoviesByID(ID);

            if (ID != 0)
            {
                businessLayer.deleteMovie(ID);
                HideAllButtons();
                ShowMainButtons();
                DisplayAllMovies();
            }

        }

        public void AppStateUpdate()
        {

            businessLayer.updateMovie(GetMovieFromUser());
            HideAllButtons();
            ShowMainButtons();
            DisplayAllMovies();
        }
        #endregion
    }
}
