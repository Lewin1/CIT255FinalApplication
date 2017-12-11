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
            btnResetQuery.Visible = false;
            btnExit.Visible = false;

            btnVote.Visible = false;
            btnDelete.Visible = false;
            btnContinue.Visible = false;

            HideEntryBoxes();
        }

        public void HideEntryBoxes()
        {
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
        }

        public void ShowMainButtons()
        {
            btnAdd.Visible = true;
            btnQuery.Visible = true;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnVote.Visible = true;
            btnExit.Visible = true;
        }

        public void ShowQueryButtons()
        {
            btnMainMenu.Visible = true;
            btnQueryByName.Visible = true;
            btnQueryByRating.Visible = true;
            btnQueryByGenre.Visible = true;
            btnResetQuery.Visible = true;
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

        public void ClearEntryBoxes()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtYear.Text = "";
            txtGenre.Text = "";
        }
        #endregion

        #region Main Menu Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            appState = AppState.Add;
            HideAllButtons();
            ShowAddForm();
            DisplayAllMovies();
            txtID.Text = businessLayer.IncrementID(businessLayer.DisplayAllMovies()).ToString();
            this.ActiveControl = txtName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            appState = AppState.Delete;
            HideAllButtons();
            ShowDeleteForm();
            DisplayAllMovies();
            lbID.Visible = false;
            txtID.Text = "Please select an item from the list above";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstDisplayList.SelectedItem != null) {
                appState = AppState.Update;
                SetUpdateValues(GetMovieFromListBox());
                this.ActiveControl = txtName;
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
            businessLayer.ReSortListID(businessLayer.DisplayAllMovies());
            Application.Exit();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            appState = AppState.None;
            HideAllButtons();
            ShowMainButtons();
            ClearEntryBoxes();
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
                    AppStateDelete(GetMovieFromListBox());
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
            businessLayer.VoteUp(lstDisplayList.SelectedItem as Model.Movie);
            lstDisplayList.Items.Clear();
            DisplayAllMovies();
        }

        private void btnVoteDown_Click(object sender, EventArgs e)
        {
            businessLayer.VoteDown(lstDisplayList.SelectedItem as Model.Movie);
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
            HideEntryBoxes();
            lbName.Visible = true;
            txtName.Visible = true;
            DisplayAllMovies();
            this.ActiveControl = txtName;

            if (txtName.Text.ToUpper() != "")
            {
                DisplayQueriedMovies(businessLayer.QueryMoviesByName(txtName.Text.ToUpper()));
                lbName.Visible = false;
                txtName.Visible = false;
                txtName.Text = "";
                HideAllButtons();
                ShowQueryButtons();

            }

        }

        private void btnQueryByType_Click(object sender, EventArgs e)
        {
            HideEntryBoxes();
            lbGenre.Visible = true;
            txtGenre.Visible = true;
            DisplayAllMovies();
            this.ActiveControl = txtGenre;

            if (txtGenre.Text.ToUpper() != "")
            {
                DisplayQueriedMovies(businessLayer.QueryMoviesByGenre(txtGenre.Text.ToUpper()));
                lbGenre.Visible = false;
                txtGenre.Visible = false;
                txtGenre.Text = "";
                HideAllButtons();
                ShowQueryButtons();
            }
        }

        private void btnQueryByRating_Click(object sender, EventArgs e)
        {
            HideEntryBoxes();
            lbRating.Visible = true;
            txtRating.Visible = true;
            DisplayAllMovies();
            this.ActiveControl = txtRating;

            if (txtRating.Text != "")
            {
                int x = 0;
                int.TryParse(txtRating.Text, out x);
                DisplayQueriedMovies(businessLayer.QueryMoviesByRating(x));
                lbRating.Visible = false;
                txtRating.Visible = false;
                txtRating.Text = "";
                HideAllButtons();
                ShowQueryButtons();
            }
        }
        #endregion

        #region Button Methods
        public void DisplayAllMovies()
        {
            lstDisplayList.Items.Clear();
            List<Movie> movies = businessLayer.DisplayAllMovies();
            List<Movie> sortedMovies = movies.OrderBy(m => m.ID).ToList();
            foreach (Movie movie in sortedMovies)
            {
                lstDisplayList.Items.Add(movie);
            }

            movies = sortedMovies;
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

            ShowAddForm();

        }

        public void AppStateAdd()
        {
            Movie movie = GetMovieFromUser();

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
            
            if (movie.Name != "" && movie.Genre != "" && movie.Year != 0)
            {
                businessLayer.addMovie(movie);
                HideAllButtons();
                ShowMainButtons();
                ClearEntryBoxes();
                DisplayAllMovies();
            }
        }

        public void AppStateDelete(Movie movie)
        {
            if (movie != null)
            {
                if (movie.ID != 0)
                {
                    businessLayer.deleteMovie(movie.ID);
                    HideAllButtons();
                    ShowMainButtons();
                    ClearEntryBoxes();
                    DisplayAllMovies();
                };
            };
        }

        public void AppStateUpdate()
        {
            businessLayer.updateMovie(GetMovieFromUser());
            HideAllButtons();
            ShowMainButtons();
            ClearEntryBoxes();
            DisplayAllMovies();
        }

        private void btnResetQuery_Click(object sender, EventArgs e)
        {
            DisplayAllMovies();
        }
        #endregion

    }
}
