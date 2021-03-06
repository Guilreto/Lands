﻿namespace Lands.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Models;

    public class LandsViewModel : BaseViewModel
    {
        #region Attributes
        private ObservableCollection<Land> lands;
        #endregion

        #region Properties
        public ObservableCollection<Land> Lands
        {
            get { return this.lands;  }
            set { SetValue(ref this.lands, value); }
        }
        #endregion

        #region Contructors
        public LandsViewModel()
        {
            this.LoadLands();
        }
        #endregion

        #region Methods
        private void LoadLands()
        {

        }
        #endregion

    }
}
