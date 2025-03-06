using MyPulsario.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;



namespace MyPulsario.Common
{
    [DataContract]
    public class PatientListModel : CommonBase<Guid>
    {
        private bool isLockedOut = false;
        private Guid id = Guid.Empty;
        private string name = string.Empty;
        public string username = string.Empty;
        private DateTime dob = DateTime.MinValue;
        private bool vitaladded = false;
        private bool havepulsariokit = false;
        private string programtype = string.Empty;
        private string nurse = string.Empty;
        private string kitNumber = string.Empty;
        private string kitScaleNumber = string.Empty;
        private int totalCount = 0;
        private int pageNumber = 0;
        private int totalPages = 0;
        private int pageSize = 0;
        private bool includeisactive = false;

       
        [DataMember]
        public int PageSize
        {
            get { return pageSize; }
            set { this.pageSize = value; }
        }
        [DataMember]
        public string ActiveCount { get; set; }
        [DataMember]
        public string InactiveCount { get; set; }

        [DataMember]
        public string Clinic { get; set; }
        [DataMember]
        public string RPM { get; set; }
        [DataMember]
        public string CCM { get; set; }
        [DataMember]
        public string PCM { get; set; }
        [DataMember]
        public string CCCM { get; set; }
        [DataMember]
        public string PulsarioKits { get; set; }

        [DataMember]
        public string ProgramType
        {
            get { return programtype; }
            set
            {
                if (value != this.programtype)
                {
                    this.programtype = value;
                    NotifyPropertyChanged("ProgramType");
                }
            }
        }
        [DataMember]
        public string Nurse
        {
            get { return nurse; }
            set
            {
                if (value != this.nurse)
                {
                    this.nurse = value;
                    NotifyPropertyChanged("nurse");
                }
            }
        }

        [DataMember]
        public bool IncludeIsActive
        {
            get { return includeisactive; }
            set { this.includeisactive = value; }
        }
        [DataMember]
        public int TotalCount
        {
            get { return totalCount; }
            set { this.totalCount = value; }
        }
        [DataMember]
        public int PageNumber
        {
            get { return pageNumber; }
            set { this.pageNumber = value; }
        }
        [DataMember]
        public int TotalPages
        {
            get { return totalPages; }
            set { this.totalPages = value; }
        }
        [DataMember]
        public Guid ID
        {
            get { return id; }
            set { this.id = value; }
        }
        [DataMember]
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        [DataMember]
        public string LoginUserName
        {
            get { return username; }
            set { this.username = value; }
        }
        [DataMember]
        public DateTime DOB
        {
            get { return dob; }
            set
            {
                if (value != this.dob)
                {
                    this.dob = value;
                    NotifyPropertyChanged("DOB");
                }
            }

        }

        [DataMember]
        public bool VitalAdded
        {
            get { return vitaladded; }
            set
            {
                if (value != this.vitaladded)
                {
                    this.vitaladded = value;
                    NotifyPropertyChanged("VitalAdded");
                }
            }

        }

        [DataMember]
        public bool HavePulsarioKit
        {
            get { return havepulsariokit; }
            set
            {
                if (value != this.havepulsariokit)
                {
                    this.havepulsariokit = value;
                    NotifyPropertyChanged("HavePulsarioKit");
                }
            }

        }

        [DataMember]
        public string KitNumber
        {
            get { return kitNumber; }
            set
            {
                if (value != this.kitNumber)
                {
                    this.kitNumber = value;
                    NotifyPropertyChanged("KitNumber");
                }
            }

        }

        [DataMember]
        public string KitScaleNumber
        {
            get { return kitScaleNumber; }
            set
            {
                if (value != this.kitScaleNumber)
                {
                    this.kitScaleNumber = value;
                    NotifyPropertyChanged("KitScaleNumber");
                }
            }

        }

        [DataMember]
        public bool IsLockedOut
        {
            get { return isLockedOut; }
            set
            {
                if (value != this.isLockedOut)
                {
                    this.isLockedOut = value;
                }
            }
        }
        public PatientListModel()
        {
        }
    }
}
