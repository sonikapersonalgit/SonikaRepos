using MyPulsario.Common;
using MyPulsario.Common.Enums;
using MyPulsario.Common.Helper;
using MyPulsario.Common.QO;
using MyPulsario.Core.Common;
using MyPulsario.Core.Common.Enums;
using MyPulsario.Core.Common.FaultDetail;
using MyPulsario.Core.DLL;
using MyPulsario.Core.IBLL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Web.Hosting;

namespace MyPulsario.Core.BLL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class BLPatient : IBLPatient, IBLPatientRest
    {
        
            private DLL.DLNurse m_dlNurse = null;
        private DLL.DLPatient m_dlPatient = null;
        private DLL.DLSetting m_dlSetting = null;
        private DLL.DLUser m_dlUser = null;
        private BLL.BLCommunication m_blCommunication = null;
        private DLL.DLLookUp m_dlLookUp = null;
        private BLCommunication GetBLCommunication()
        {
            if (m_blCommunication == null)
                m_blCommunication = new BLL.BLCommunication();

            return m_blCommunication;
        }
        private DLNurse GetDLNurse()
        {
            if (m_dlNurse == null)
                m_dlNurse = new DLL.DLNurse();

            return m_dlNurse;
        }
        private DLLookUp GetDLLookUp()
        {
            if (m_dlLookUp == null)
                m_dlLookUp = new DLL.DLLookUp();

            return m_dlLookUp;
        }


        private DLPatient GetDLPatient()
        {
            if (m_dlPatient == null)
                m_dlPatient = new DLL.DLPatient();

            return m_dlPatient;
        }


        private DLSetting GetDLSetting()
        {
            if (m_dlSetting == null)
                m_dlSetting = new DLL.DLSetting();

            return m_dlSetting;
        }

        private DLUser GetDLUser()
        {
            if (m_dlUser == null)
                m_dlUser = new DLL.DLUser();

            return m_dlUser;
        }



        private string EncryptString(string stringToEncrypt)
        {
            return CryptorEngine.Encrypt(stringToEncrypt, ApplicationStrings.CryptorKey, true);
        }
        public string SetICDQueAns(string PatientID, Guid UserID, string type, bool status)
        {
            return GetDLPatient().SetICDQueAns(PatientID, UserID, type, status);
        }
        public ICDQueAns GetICDQueAns(Guid PatientID)
        {
            return GetDLPatient().GetICDQueAns(PatientID);
        }

        public void SavePatientMedicationAchiveStatus(PatientMedicationQO medQO)
        {
            GetDLPatient().SavePatientMedicationAchiveStatus(medQO);
        }
        private string DecryptString(string stringToDecrypt)
        {
            return CryptorEngine.Decrypt(stringToDecrypt, ApplicationStrings.CryptorKey, true);
        }

        public ObservableCollection<PatientReportWithVitals> GetPatientReportWithVitals(Guid OrgID, Guid ProvID)
        {
            ObservableCollection<PatientReportWithVitals> Patientlist = GetDLPatient().GetPatientReportWithVitals(OrgID, ProvID);
            return Patientlist;
        }
        public ObservableCollection<PatientReportWithVitals> GetPatientReportWithVitalsCustom(Guid OrgID, Guid ProvID, string startdate, string enddate)
        {
            ObservableCollection<PatientReportWithVitals> Patientlist = GetDLPatient().GetPatientReportWithVitalsCustom(OrgID, ProvID, startdate, enddate);
            return Patientlist;
        }

        public ObservableCollection<PatientReportWithVitalsRest> GetPatientReportWithVitalsRest(Guid OrgID, Guid ProvID)
        {
            ObservableCollection<PatientReportWithVitalsRest> Patientlist = GetDLPatient().GetPatientReportWithVitalsRest(OrgID, ProvID);
            return Patientlist;
        }

        public void DeletePatientMedication(PatientMedicationQO medQO)
        {
            GetDLPatient().DeletePatientMedication(medQO);
        }

        public void FinalizeMonthlyReportNew(Guid id, Guid orgid, string startdate, string enddate)
        {
            GetDLPatient().FinalizeMonthlyReportNew(id, orgid, startdate, enddate);
        }

        public AdditionalProvider SaveAdditionalProvider(AdditionalProvider additionalProvider, out Guid returnID)
        {
            if (additionalProvider == null)
                throw new ArgumentNullException();
            returnID = Guid.Empty;
            return GetDLPatient().SaveAdditionalProvider(additionalProvider, out returnID);
        }

        public void SaveArchivedMedicationComment(PatientMedication med)
        {
            GetDLPatient().SaveArchivedMedicationComment(med);
        }
        public PatientMedicalData SavePatientMedicalData(PatientMedicalData medicalData)
        {
            PatientMedicalData savedMedData = GetDLPatient().SavePatientMedicalData(medicalData);
            return savedMedData;
        }
        public Person GetPrimaryCareProvider(PersonQO personQO)
        {
            if (personQO == null || personQO.ID == Guid.Empty)
                throw new ArgumentNullException();


            return GetDLPatient().GetPrimaryCareProvider(personQO);

        }


        public Person GetPatientShort(PatientQO ptQO)
        {


            return GetDLPatient().GetPatientShort(ptQO);
        }

        public void SavePatientDocument(PatientDocument documentInfo)
        {
            Person patient = GetPatientShort(new PatientQO() { ID = documentInfo.PatientID });
            //get patient info needed for patient folder lookup/creation
            //MemoryStream ms = new MemoryStream(documentInfo.DocumentFile);

            string patientPath =
                string.Format(@"{0}\{1}\" + @"\{2}" + @"_{3}_{4}\", GetDLSetting()
                        .GetDefaultSetting(new SettingQO() { SettingID = MyPulsario.Common.Enums.SettingItem.PatientDocumentRoot }),
                        patient.OrganizationID, documentInfo.PatientID, patient.LastName, patient.FirstName);
            string folderPath = HostingEnvironment.MapPath("~/Uploads/");
            patientPath =
                string.Format(@"{0}\{1}\" + @"{2}" + @"_{3}_{4}\", string.Format(@"{0}{1}\{2}", folderPath, "MyPulsario", "PatientDocuments"),
                        patient.OrganizationID, documentInfo.PatientID, patient.LastName, patient.FirstName);

            if (documentInfo.DocumentFile != null)
            {

                //validate patient folder and create it if does not exist
                if (!Directory.Exists(patientPath))
                {
                    Directory.CreateDirectory(patientPath);
                }

                //validate file and save id file doen not exist
                if (!File.Exists(patientPath + documentInfo.FileName))
                {
                    BinaryWriter fs = new BinaryWriter(new FileStream(patientPath + documentInfo.FileName, FileMode.Append, FileAccess.Write));
                    fs.Write(documentInfo.DocumentFile);
                    fs.Close();
                }
                else
                {
                    File.Delete(patientPath + documentInfo.FileName);
                    BinaryWriter fs = new BinaryWriter(new FileStream(patientPath + documentInfo.FileName, FileMode.Append, FileAccess.Write));
                    fs.Write(documentInfo.DocumentFile);
                    fs.Close();
                    //throw new IOException("File Already Exisits!");
                }
                GetDLPatient().SavePatientDocument(documentInfo);
            }
        }

        public void DeletePatientDocument(PatientDocumentQO docQO)
        {
            if (docQO.DocumentID == Guid.Empty)
                throw new ArgumentNullException("Document ID must be provided.");

            this.GetDLPatient().SavePatientDocumentStatus(docQO.DocumentID, false);

            if (File.Exists(docQO.PhysicalPath))
                File.Delete(docQO.PhysicalPath);

        }
        public ObservableCollection<PatientDocument> GetPatientDocuments(PatientQO patientQO)
        {
            return GetDLPatient().GetPatientDocuments(patientQO);
        }
        public void DeletePatientAllergy(PatientAllergyQO allergyQO)
        {
            GetDLPatient().DeletePatientAllergy(allergyQO);
        }
        public void DeletePatientMedicalData(PatientMedicalDataQO medDataQO)
        {
            GetDLPatient().DeletePatientMedicalData(medDataQO);
        }
        public void SavePatientPulsarioKit(bool HaveKit, string KitNumber, string KitScaleNumber, Guid patientID)
        {
            GetDLPatient().SavePatientPulsarioKit(HaveKit, KitNumber, KitScaleNumber, patientID);
        }
        public CCMReports GetCCMPreviousReports(CCMPreviousReports ccprev, int iscomplete, string programType)
        {
            if (ccprev == null)
                throw new ArgumentNullException();

            return GetDLPatient().GetCCMPreviousReports(ccprev, iscomplete,programType);
        }
        public CCMReports GetPCMPreviousReports(CCMPreviousReports ccprev, int iscomplete, string programType)
        {
            if (ccprev == null)
                throw new ArgumentNullException();

            return GetDLPatient().GetPCMPreviousReports(ccprev, iscomplete, programType);
        }
        
        public CCMReports GetApptReviewTimeByNurse(CCMPreviousReports ccprev, int iscomplete, Guid? completedby)
        {
            if (ccprev == null)
                throw new ArgumentNullException();

            return GetDLPatient().GetApptReviewTimeByNurse(ccprev, iscomplete, completedby);
        }
        public ObservableCollection<CCMReportsCountByNurse> GetCCMRevTimeByNurse(CCMPreviousReports ccprev, int iscomplete)
        {
            if (ccprev == null)
                throw new ArgumentNullException();

            return GetDLPatient().GetCCMRevTimeByNurse(ccprev, iscomplete);
        }
        public CCMReportsRest GetCCMPreviousReportsRest(CCMPreviousReportsRest ccprev, int iscomplete)
        {
            if (ccprev == null)
                throw new ArgumentNullException();

            return GetDLPatient().GetCCMPreviousReportsRest(ccprev, iscomplete);
        }

        public CCMReport CCMReportRest(string id, string orgid, int iscomplete)
        {
            CCMReport res = new CCMReport();
            res.Heading = new ReportHeading();
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(orgid) || iscomplete < 0)
            {
                res.CCMRecords = new PrevReportsRest();
                res.Status = "0";
                res.Message = "Fail";
                
            }
            try {
                res.Message = "353";
            CCMPreviousReportsRest ccprev = new CCMPreviousReportsRest();
            DateTime now = DateTime.Now;
            var StartDate = new DateTime(now.Year, now.Month, 1);
                var lastDayOfMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                var EndDate = new DateTime(now.Year, now.Month, lastDayOfMonth);
                
                ccprev.StartDate = StartDate.ToString("yyyy-MM-dd");
            ccprev.EndDate = EndDate.ToString("yyyy-MM-dd");
               
                if (!string.IsNullOrEmpty(orgid))
                ccprev.OrganizationID = (orgid);

            ccprev.NurseID = (id);
               
                var ccmreport = GetCCMPreviousReportsRest(ccprev, iscomplete);
               
                var lstreports = ccmreport.Previous;
            var ccmreportinc = GetCCMPreviousReportsRest(ccprev, 0);
            var incom = ccmreportinc.Previous;

            //if (lstreports.Count > 0)
            //{
                
                    res.Heading = ccmreport.Heading;
            //}
            PrevReportsRest objrep = new PrevReportsRest();
            var cnt = CompletedReportCount(Guid.Parse(orgid), ccprev.StartDate, ccprev.EndDate, Guid.Parse(id));

                // objrep.ListIncompReport = new List<CCMPreviousReportsRest>(); ;
                if (lstreports.Count > 0)
                {
                    objrep.ListReport = lstreports;
                }
                else {
                    objrep.ListReport = new List<CCMPreviousReportsRest>();
                }
            objrep.TotalData = cnt.CompletedCCM;
            objrep.TotalIncompData = cnt.InCompleteCCM;
            objrep.TotalReviewData = cnt.CompletedCCM + cnt.InCompleteCCM;
                res.CCMRecords = objrep;
                res.Status = "1";
                res.Message = "Successful";
            }
            catch (Exception ex)
            {
                res.CCMRecords = new PrevReportsRest();
                res.Heading = new ReportHeading();
                res.Status = "0";
                res.Message = "Please contact administrator.";
            }
            return res;
        }

        public ReportCount CompletedReportCount(Guid OrgID, string startdate, string enddate, Guid? NurseID, string programType = "CCM")
        {


            return GetDLPatient().CompletedReportCount(OrgID, startdate, enddate, NurseID,programType);
        }
        public ObservableCollection<CCMPreviousReports> GetPatientPreviousReports(CCMPreviousReports ccprev, int iscomplete)
        {
            if (ccprev == null)
                throw new ArgumentNullException();

            return GetDLPatient().GetPatientPreviousReports(ccprev, iscomplete);
        }


        public ObservableCollection<PatientAllergy> GetPatientAllergy(PatientQO patientQO)
        {
            return GetDLPatient().GetPatientAllergy(patientQO);
        }

        public ObservableCollection<PatientMedicalData> GetPatientMedicalData(PatientMedicalDataQO medDataQO)
        {
            ObservableCollection<PatientMedicalData> medData = GetDLPatient().GetPatientMedicalData(medDataQO);
            return medData;
        }

        public ObservableCollection<PatientAlertCounter> GetPatientAlertCount(Guid PatientID)
        {
            ObservableCollection<PatientAlertCounter> medData = GetDLPatient().GetPatientAlertCount(PatientID);
            return medData;
        }
        public ObservableCollection<PatientMedication> CheckPatientMedication(PatientMedicationQO medicationQO)
        {
            var meds = new ObservableCollection<PatientMedication>(GetDLPatient().GetPatientMedication(medicationQO).ToList());
            return meds;
        }
        public ObservableCollection<PatientMedication> GetPatientMedication(PatientMedicationQO medicationQO)
        {
            //var meds = new ObservableCollection<PatientMedication>(GetDLPatient().GetPatientMedication(medicationQO).OrderByDescending(x => x.CreationDate).ToList());
            var meds = new ObservableCollection<PatientMedication>(GetDLPatient().GetPatientMedication(medicationQO).ToList());
            PatientQO allergyQO = new PatientQO();
            allergyQO.ID = medicationQO.PatientID;
            var allergies = new ObservableCollection<PatientAllergy>(GetDLPatient().GetPatientAllergy(allergyQO).ToList());

            var medsOrig = meds.ToList();

            if (!medicationQO.IsArchivedFL)
            {
                var inactiveMeds = new ObservableCollection<PatientMedication>(GetDLPatient().GetPatientMedication(new PatientMedicationQO() { PatientID = medicationQO.PatientID, IsArchivedFL = true }).OrderByDescending(x => x.ArchivedDate).ToList());

                inactiveMeds.ToList().ForEach(x => x.CreationDate = x.ArchivedDate);

                var patient = GetDLPatient().GetPatientDemographics(new PatientQO() { ID = medicationQO.PatientID });
                var medicalData = GetPatientMedicalData(new PatientMedicalDataQO() { PatientID = medicationQO.PatientID }).OrderByDescending(x => x.CreationDate).FirstOrDefault();
                var medicalHistory = GetPatientMedicalHistory(new PatientMedicalHistoryQO() { PatientID = medicationQO.PatientID }).Where(x => x.IsActive == true).ToList();
                var vitalSigns = GetPatientVitalSigns(new PatientVitalSignsQO() { PatientID = medicationQO.PatientID }, false).ToList();

                var LuMedicalHistoryType = GetDLLookUp().GetLookUpValues(new MasterLookUpQO()
                {
                    TableType = LuTableType.LuMedicalHistoryType,
                    OrganizationID = patient.OrganizationID,//GetDLUser().GetUserOrganization(patient.OrganizationID),
                }).Where(x => x.IsActiveFL == true).ToList();


                #region function for color
                Func<MedicationClass, PatientMedication> GetMed = (medClass) =>
                {
                    var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)medClass);
                    if (ret == null)
                    {
                        ret = new PatientMedication()
                        {
                            MedicationReasonTypeID = (int)MedicationReasonType.Not_currently_prescribed,
                            DivColor = string.Empty,
                            MedicationClassID = (int)medClass,
                        };
                        meds.Add(ret);
                    }
                    else if (ret.MedicationReasonTypeID != (int)MedicationReasonType.None)
                    {

                        if (ret.MedicationReasonTypeID == (int)MedicationReasonType.Allergy_to_Medication)
                        //||
                        //ret.MedicationReasonTypeID == (int)MedicationReasonType.Previous_adverse_reaction_or_intolerance)
                        {
                            if (string.IsNullOrEmpty(ret.DivColor))
                            {
                                ret.DivColor = GetColor(MedicationScale.Blue);
                            }
                        }
                        //else if (ret.MedicationReasonTypeID == (int)MedicationReasonType.Not_currently_prescribed ||
                        //    ret.MedicationReasonTypeID == (int)MedicationReasonType.Not_indicated_for_this_patient)
                        //{
                        //    if (string.IsNullOrEmpty(ret.DivColor))
                        //    {
                        //        ret.DivColor = GetColor(MedicationScale.Red);
                        //    }
                        //}
                        if (ret.ID != Guid.Empty)
                        {
                            ret.IsDataAdded = true;
                        }
                    }
                    else
                    {
                        if (ret.ID != Guid.Empty)
                        {
                            ret.IsDataAdded = true;
                        }
                    }
                    if (ret.IsDoseMax == 1)
                    {
                        ret.MedicationScaleID = (int)MedicationScale.Green;
                        ret.MedicationReasonTypeID = Int32.MinValue;
                    }
                    else if (ret.IsDoseMax == 0)
                    {
                        ret.MedicationScaleID = (int)MedicationScale.Yellow;
                    }
                    //else
                    //{
                    //    //if (ret.MedicationClassID == (int)MedicationClass.Aldosterone_antagonist)
                    //    //{
                    //    //    ret.MedicationScaleID = (int)MedicationScale.Yellow;
                    //    //}
                    //    if (ret.MedicationClassID == (int)MedicationClass.Diuretic)
                    //    {
                    //        ret.MedicationScaleID = (int)MedicationScale.Green;
                    //    }
                    //}
                    return ret;
                };

                Func<MedicationClass, bool> WasPrescribed = (medClass) =>
                {
                    return inactiveMeds.Any(x => x.MedicationClassID == (int)medClass) ||
                        medsOrig.Any(x =>
                            x.MedicationClassID == (int)medClass &&
                            x.MedicationReasonTypeID == (int)MedicationReasonType.Not_currently_prescribed);
                };

                Func<MedicationClass, bool> IsPrescribed = (medClass) =>
                {
                    return GetMed(medClass).MedicationReasonTypeID == (int)MedicationReasonType.None;
                };

                Func<MedicationClass, bool> CanPrescribe = (medClass) =>
                {
                    return GetMed(medClass).MedicationReasonTypeID == (int)MedicationReasonType.Not_currently_prescribed;
                };

                Func<MedicationClass, bool> IsIntolerant = (medClass) =>
                {
                    return GetMed(medClass).MedicationReasonTypeID == (int)MedicationReasonType.Previous_adverse_reaction_or_intolerance;
                };

                Func<MedicationClass, bool> IsAllergic = (medClass) =>
                {
                    return GetMed(medClass).MedicationReasonTypeID == (int)MedicationReasonType.Allergy_to_Medication;
                };

                Func<MedicationClass, bool> IsContraIndicated = (medClass) =>
                {
                    return IsIntolerant(medClass) || IsAllergic(medClass);
                };

                Action<MedicationClass> SetShouldPrescribe = (medClass) =>
                {
                    GetMed(medClass).DivColor = "redDiv";
                };

                Func<MedicationClass, PatientMedication> SetShouldNotPrescribe = (medClass) =>
                {
                    var med = GetMed(medClass);
                    int isallegy1 = 0;
                    var allergy1 = allergies.FirstOrDefault(m => m.Name == medClass.ToString());
                    if (allergy1 != null)
                    {
                        isallegy1 = 1;
                    }
                    if (IsAllergic(medClass) || isallegy1 > 0)
                    {
                        med.MedicationScaleID = (int)MedicationScale.Blue;
                        med.DivColor = GetColor(MedicationScale.Blue);
                    }
                    else if (IsIntolerant(medClass))
                    {
                        med.MedicationScaleID = (int)MedicationScale.Blue;
                        med.DivColor = GetColor(MedicationScale.Blue);
                    }
                    else
                    {
                        //if (med.Name == "")
                        //{
                        //    med.DivColor = GetColor(MedicationScale.None);
                        //}
                        if (medClass == MedicationClass.Beta_blocker)
                        {
                            med.MedicationScaleID = (int)MedicationScale.Red;
                            //     med.MedicationReasonTypeID = (int)MedicationReasonType.Not_indicated_for_this_patient;
                            med.DivColor = GetColor(MedicationScale.Red);
                        }

                    }
                    return med;
                };

                Func<string, int> GetLuMedicalHistoryTypeID = (name) =>
                {
                    int ret = Int32.MinValue;
                    var item = LuMedicalHistoryType.FirstOrDefault(x => x.IsActiveFL && x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                    if (item != null)
                    {
                        ret = item.ID;
                    }
                    return ret;
                };

                Func<string, bool> HasMedicalHistoryType = (historyTypeName) =>
                {
                    var arrhythmiaID = GetLuMedicalHistoryTypeID(historyTypeName);

                    return medicalHistory.Any(x => x.MedicalHistoryTypeID == arrhythmiaID);
                };
                Func<string, bool> HasICDMedicalHistoryType = (historyTypeName) =>
                {


                    return medicalHistory.Any(x => x.ICDDeviceTypeName == historyTypeName);
                };

                Func<MedicationClass, bool> AtMaximumTherapy = (medClass) =>
                {
                    return (IsPrescribed(medClass) && GetMed(medClass).MedicationScaleID == (int)MedicationScale.Green);// || !CanPrescribe(medClass);
                };
                #endregion
                bool is_flag = false;
                bool is_meddata = false;
                foreach (MedicationClass val in Enum.GetValues(typeof(MedicationClass)))
                {
                    var med = GetMed(val);
                    if (med.MedicationClassName != "")
                    {
                        is_meddata = true;
                    }
                    if (string.IsNullOrEmpty(med.DivColor))
                    {
                        med.DivColor = GetColor((MedicationScale)med.MedicationScaleID);
                    }
                    if (val == MedicationClass.ACE_inhibitor && med.ID != Guid.Empty)
                    {
                        is_flag = true;
                        med.DivColor = GetColor(MedicationScale.Red);
                        if (IsPrescribed(MedicationClass.ACE_inhibitor))
                        {

                            SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);
                            SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);
                        }
                        if (IsAllergic(MedicationClass.ACE_inhibitor))
                        {

                            med.DivColor = GetColor(MedicationScale.Blue);
                        }
                    }
                    if (val == MedicationClass.ARB && med.ID != Guid.Empty)
                    {
                        is_flag = true;
                        med.DivColor = GetColor(MedicationScale.Red);
                        if (IsPrescribed(MedicationClass.ARB))
                        {

                            SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue);
                            SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);
                        }
                        if (IsAllergic(MedicationClass.ARB))
                        {

                            med.DivColor = GetColor(MedicationScale.Blue);
                        }
                    }
                    if (val == MedicationClass.Entresto && med.ID != Guid.Empty)
                    {
                        is_flag = true;
                    }
                    if (med.IsDoseMax == 1)
                    {
                        med.DivColor = GetColor(MedicationScale.Green);
                    }
                    if (med.IsDoseMax == 0)
                    {
                        med.DivColor = GetColor(MedicationScale.Yellow);
                    }
                    int isallegy = 0;

                    var allergy2 = allergies.FirstOrDefault(m => m.ClassID == med.MedicationClassID);
                    if (med.MedicationClassID == 7)
                    {
                        allergy2 = null;
                    }
                    if (allergy2 != null)
                    {

                        isallegy = 1;
                    }
                    if (isallegy > 0)
                    {
                        med.MedicationScaleID = (int)MedicationScale.Blue;
                        med.DivColor = GetColor(MedicationScale.Blue);
                    }

                }
                if (!is_flag)
                {
                    if (!is_meddata && medicalData == null && (vitalSigns == null || vitalSigns.Count == 0) && (medicalHistory == null || medicalHistory.Count == 0) && (allergies == null || allergies.Count == 0))
                    {
                        is_flag = false;
                        SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.None);
                        SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.None);
                        SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.None);
                    }
                    else
                    {
                        is_flag = true;
                        SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Red);
                        SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Red);
                        SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Red);
                    }
                }

                //if (!IsPrescribed(MedicationClass.Entresto))
                //{
                //    SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);
                //}
                //if (!IsPrescribed(MedicationClass.ARB) && !IsPrescribed(MedicationClass.ACE_inhibitor) && IsPrescribed(MedicationClass.Entresto))
                //{
                //    SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);
                //    SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue);
                //}
                #region allergies
                int isallegytoarb = 0;
                int isallegytoentresto = 0;
                int isallegytoace = 0;
                int isallegytobeta = 0;
                int isallegytodixo = 0;
                int isallegytoaldo = 0;
                int isallegytohydral = 0;
                int isallegytohydiur = 0;
                int isallegytocorl = 0;
                var allergy = allergies.FirstOrDefault(m => m.ClassID == (int)MedicationClass.ARB);
                if (allergy != null)
                {
                    isallegytoarb = 1;
                }
                allergy = allergies.FirstOrDefault(m => m.ClassID == (int)MedicationClass.Corlanor);
                if (allergy != null)
                {
                    isallegytocorl = 1;
                }
                allergy = allergies.FirstOrDefault(m => m.ClassID == (int)MedicationClass.ACE_inhibitor);
                if (allergy != null)
                {
                    isallegytoace = 1;
                }
                allergy = allergies.FirstOrDefault(m => m.ClassID == (int)MedicationClass.Entresto);
                if (allergy != null)
                {
                    isallegytoentresto = 1;
                }
                allergy = allergies.FirstOrDefault(m => m.ClassID == (int)MedicationClass.Beta_blocker);
                if (allergy != null)
                {
                    isallegytobeta = 1;
                }
                allergy = allergies.FirstOrDefault(m => m.ClassID == (int)MedicationClass.Hydralazine);
                if (allergy != null)
                {
                    isallegytohydral = 1;
                }
                allergy = allergies.FirstOrDefault(m => m.ClassID == (int)MedicationClass.Aldosterone_antagonist);
                if (allergy != null)
                {
                    isallegytoaldo = 1;
                }
                allergy = allergies.FirstOrDefault(m => m.ClassID == (int)MedicationClass.Digoxin);
                if (allergy != null)
                {
                    isallegytodixo = 1;
                }
                allergy = allergies.FirstOrDefault(m => m.ClassID == (int)MedicationClass.Diuretic);
                if (allergy != null)
                {
                    isallegytohydiur = 1;
                }
                #endregion
                if (!IsPrescribed(MedicationClass.Diuretic) && !IsAllergic(MedicationClass.Diuretic) && isallegytohydiur == 0)
                {
                    SetShouldNotPrescribe(MedicationClass.Diuretic).DivColor = GetColor(MedicationScale.None);


                }
                else if (IsAllergic(MedicationClass.Diuretic) || isallegytohydiur > 0)
                {
                    SetShouldNotPrescribe(MedicationClass.Diuretic).DivColor = GetColor(MedicationScale.Blue);
                }
                else if (IsPrescribed(MedicationClass.Diuretic) && isallegytohydiur == 0)
                {
                    SetShouldNotPrescribe(MedicationClass.Diuretic).DivColor = GetColor(MedicationScale.Green);
                }
                if (is_flag)
                {
                    var ret_ARB = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.ARB);
                    var ret_Beta = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Beta_blocker);
                    var ret_ACE = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.ACE_inhibitor);
                    var ret_Entresto = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Entresto);
                    var ret_aldo = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Aldosterone_antagonist);
                    #region color codes
                    if (medicalData != null && medicalData.EjectionFractionPercent >= 40)
                    {
                        //if (HasMedicalHistoryType("Hypertension"))
                        //{
                        //SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.None);
                        if (IsPrescribed(MedicationClass.ACE_inhibitor) && isallegytoace == 0)
                        {
                            //if (IsPrescribed(MedicationClass.ARB))
                            //{ SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue); }
                            //else
                            //{
                            SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);
                            //}
                            SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);
                            SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Red);
                            var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.ACE_inhibitor);
                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                if (ret.IsDoseMax == 1)
                                {
                                    SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Green);
                                }
                                else if (ret.IsDoseMax == 0)
                                {
                                    SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Yellow);
                                }
                            }
                        }
                        else if (CanPrescribe(MedicationClass.ACE_inhibitor) && isallegytoace == 0)
                        {
                            //if (IsPrescribed(MedicationClass.ARB))
                            //{ SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue); }
                            //else
                            //{
                            //SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);
                            //}
                            //SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);
                            SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Red);
                            var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.ACE_inhibitor);
                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                if (ret.IsDoseMax == 1)
                                {
                                    SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Green);
                                }
                                else if (ret.IsDoseMax == 0)
                                {
                                    SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Yellow);
                                }
                            }
                        }
                        else if (IsAllergic(MedicationClass.ACE_inhibitor) || isallegytoace > 0)
                        {
                            SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue);

                        }
                        else
                        {
                            SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.None);
                        }
                        if (!IsPrescribed(MedicationClass.ACE_inhibitor) && IsPrescribed(MedicationClass.ARB) && isallegytoarb == 0)
                        {
                            SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue);
                            SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);
                            SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Red);
                            var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.ARB);
                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                if (ret.IsDoseMax == 1)
                                {
                                    SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Green);
                                }
                                else if (ret.IsDoseMax == 0)
                                {
                                    SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Yellow);
                                }
                            }
                        }
                        else if ((!IsPrescribed(MedicationClass.ACE_inhibitor) || isallegytoace > 0) && CanPrescribe(MedicationClass.ARB) && isallegytoarb == 0)
                        {
                            SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Red);
                            var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.ARB);
                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                if (ret.IsDoseMax == 1)
                                {
                                    SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Green);
                                }
                                else if (ret.IsDoseMax == 0)
                                {
                                    SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Yellow);
                                }
                            }
                        }
                        else if ((IsPrescribed(MedicationClass.ACE_inhibitor) && isallegytoace == 0) || IsAllergic(MedicationClass.ARB) || isallegytoarb > 0)
                        {
                            SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);

                        }
                        //else
                        //{
                        //    SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.None);
                        //}
                        if (IsPrescribed(MedicationClass.Beta_blocker) && isallegytobeta == 0)
                        {
                            SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Red);
                            var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Beta_blocker);
                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                if (ret.IsDoseMax == 1)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Green);
                                }
                                else if (ret.IsDoseMax == 0)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Yellow);
                                }
                            }
                        }
                        else if (CanPrescribe(MedicationClass.Beta_blocker) && isallegytobeta == 0)
                        {
                            SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Red);
                            var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Beta_blocker);
                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                if (ret.IsDoseMax == 1)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Green);
                                }
                                else if (ret.IsDoseMax == 0)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Yellow);
                                }
                            }
                        }
                        else if (IsAllergic(MedicationClass.Beta_blocker) || isallegytobeta > 0)
                        {
                            SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Blue);

                        }
                        else
                        {
                            SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.None);
                        }
                        //}

                        if (CanPrescribe(MedicationClass.Entresto))
                        {
                            SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);
                        }
                        SetShouldNotPrescribe(MedicationClass.Other).DivColor = GetColor(MedicationScale.None);

                    }
                    else
                    {
                        //if (is_flag)
                        //{
                        if (IsPrescribed(MedicationClass.ACE_inhibitor) && isallegytoace == 0)
                        {
                            SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Red);
                            var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.ACE_inhibitor);
                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                if (ret.IsDoseMax == 1)
                                {
                                    SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Green);
                                }
                                else if (ret.IsDoseMax == 0)
                                {
                                    SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Yellow);
                                }
                            }
                            SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);

                            SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);

                        }
                        else if (CanPrescribe(MedicationClass.ACE_inhibitor) && isallegytoace == 0)
                        {
                            SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Red);

                        }
                        else
                        {
                            if (IsContraIndicated(MedicationClass.ACE_inhibitor))
                            {
                                SetShouldNotPrescribe(MedicationClass.ACE_inhibitor);

                                //if (CanPrescribe(MedicationClass.ARB))
                                //{
                                //    SetShouldPrescribe(MedicationClass.ARB);
                                //}
                                //else if (IsContraIndicated(MedicationClass.ARB))
                                //{
                                //    SetShouldNotPrescribe(MedicationClass.ARB);
                                //}
                            }
                            else
                            {
                                if (IsContraIndicated(MedicationClass.ARB))
                                {
                                    //if (CanPrescribe(MedicationClass.Hydralazine))
                                    //{
                                    //    SetShouldPrescribe(MedicationClass.Hydralazine);
                                    //}
                                    //else 
                                    if (IsContraIndicated(MedicationClass.Hydralazine))
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Hydralazine);
                                    }
                                }
                                else
                                {
                                    if (IsPrescribed(MedicationClass.ACE_inhibitor))
                                    {
                                        //if (CanPrescribe(MedicationClass.ARB))
                                        //{
                                        //    SetShouldNotPrescribe(MedicationClass.ARB);
                                        //}
                                        //else {
                                        //    SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);
                                        //}
                                        if (IsPrescribed(MedicationClass.ARB))
                                        { SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue); }
                                        else
                                        {
                                            SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);
                                        }
                                        SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);
                                    }
                                    else
                                    {
                                        if (isallegytoace > 0 || IsAllergic(MedicationClass.ACE_inhibitor))
                                        {
                                            SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue);
                                        }
                                        //if (CanPrescribe(MedicationClass.ARB))
                                        //{
                                        //    SetShouldPrescribe(MedicationClass.ARB);
                                        //}
                                    }
                                }
                            }
                        }
                        if (!IsPrescribed(MedicationClass.ACE_inhibitor) && IsPrescribed(MedicationClass.ARB) && isallegytoarb == 0)
                        {
                            SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Red);
                            var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.ARB);
                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                if (ret.IsDoseMax == 1)
                                {
                                    SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Green);
                                }
                                else if (ret.IsDoseMax == 0)
                                {
                                    SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Yellow);
                                }
                            }

                            SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue);

                            SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);

                        }
                        else if ((!IsPrescribed(MedicationClass.ACE_inhibitor) || isallegytoace > 0) && CanPrescribe(MedicationClass.ARB) && isallegytoarb == 0)
                        {
                            SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Red);


                        }
                        else if (IsPrescribed(MedicationClass.ACE_inhibitor) || isallegytoarb > 0)
                        {
                            SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);
                        }

                        //}
                        //if (CanPrescribe(MedicationClass.Beta_blocker))
                        //{
                        //    SetShouldPrescribe(MedicationClass.Beta_blocker);
                        //}
                        //else if (IsContraIndicated(MedicationClass.Beta_blocker))
                        //{
                        //    SetShouldNotPrescribe(MedicationClass.Beta_blocker);
                        //}
                        //else
                        if ((IsPrescribed(MedicationClass.Beta_blocker) || CanPrescribe(MedicationClass.Beta_blocker)) && isallegytobeta == 0)
                        {
                            SetShouldNotPrescribe(MedicationClass.Beta_blocker);
                            var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Beta_blocker);
                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                if (ret.IsDoseMax == 1)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Green);
                                }
                                else if (ret.IsDoseMax == 0)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Yellow);
                                }
                            }
                        }
                        else if (isallegytobeta > 0)
                        {
                            SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Blue);
                        }

                    }
                    if ((IsPrescribed(MedicationClass.Aldosterone_antagonist) || CanPrescribe(MedicationClass.Aldosterone_antagonist)) && isallegytoaldo == 0)
                    {
                        var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Aldosterone_antagonist);
                        if (medicalData != null &&
                            (/*medicalData.NYHAClassID == NYHAClassificationType.II || acc to rule no 5*/
                            medicalData.NYHAClassID == NYHAClassificationType.III ||
                            medicalData.NYHAClassID == NYHAClassificationType.IV))
                        {
                            //Is the patients gfr>30 ml/min and potassium <5.0mEq/dl
                            SetShouldNotPrescribe(MedicationClass.Aldosterone_antagonist).DivColor = GetColor(MedicationScale.Red);

                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.Aldosterone_antagonist).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                if (ret.IsDoseMax == 1)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Aldosterone_antagonist).DivColor = GetColor(MedicationScale.Green);
                                }
                                else if (ret.IsDoseMax == 0)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Aldosterone_antagonist).DivColor = GetColor(MedicationScale.Yellow);
                                }
                            }
                        }
                        else
                        {
                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.Aldosterone_antagonist).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                SetShouldNotPrescribe(MedicationClass.Aldosterone_antagonist).DivColor = GetColor(MedicationScale.None);
                            }
                        }


                    }

                    else if (IsContraIndicated(MedicationClass.Aldosterone_antagonist))
                    {
                        SetShouldNotPrescribe(MedicationClass.Aldosterone_antagonist);
                    }
                    else if (isallegytoaldo > 0)
                    {
                        SetShouldNotPrescribe(MedicationClass.Aldosterone_antagonist).DivColor = GetColor(MedicationScale.Blue);
                    }


                    if (isallegytohydral > 0)
                    {

                        SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Blue);
                    }
                    else if ((IsPrescribed(MedicationClass.Hydralazine) || CanPrescribe(MedicationClass.Hydralazine)) && isallegytohydral == 0)
                    {
                        var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Hydralazine);
                        if (
                            medicalData != null

                             && //(AtMaximumTherapy(MedicationClass.ACE_inhibitor) || AtMaximumTherapy(MedicationClass.ARB) || AtMaximumTherapy(MedicationClass.Entresto))
                             (ret_ACE.IsMaxDose || ret_ACE.IsDoseMax == 1 || ret_ARB.IsMaxDose || ret_ARB.IsDoseMax == 1 || ret_Entresto.IsDoseMax == 1 || ret_Entresto.IsMaxDose)
                             )
                        {
                            SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Red);

                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                if (ret.IsDoseMax == 1)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Green);
                                }
                                else if (ret.IsDoseMax == 0)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Yellow);
                                }
                            }
                            if (patient.RaceID == RaceType.Black_or_African_American && (medicalData.NYHAClassID == NYHAClassificationType.III ||
                             medicalData.NYHAClassID == NYHAClassificationType.IV))
                            {
                                SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Red);
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    if (ret.IsDoseMax == 1)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else if (ret.IsDoseMax == 0)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Yellow);
                                    }
                                }
                            }
                            else if (patient.RaceID == RaceType.Black_or_African_American && (medicalData.NYHAClassID == NYHAClassificationType.I ||
                             medicalData.NYHAClassID == NYHAClassificationType.II))
                            {
                                SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.None);
                            }


                        }

                        else
                        {
                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.None);
                            }
                        }
                    }
                    else if (IsContraIndicated(MedicationClass.Hydralazine))
                    {
                        SetShouldNotPrescribe(MedicationClass.Hydralazine);
                    }

                    if (isallegytocorl > 0)
                    {
                        SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Blue);
                    }
                    else if ((IsPrescribed(MedicationClass.Corlanor)) && isallegytocorl == 0)
                    {
                        var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Corlanor);
                        //var hasAbove70BPM = vitalSigns.Any(x => !x.Pulse.Equals("N/A", StringComparison.OrdinalIgnoreCase) && int.Parse(x.Pulse) >= 70);
                        var vitaldata = vitalSigns.OrderByDescending(x => x.CreationDate).FirstOrDefault();
                        var hasAbove70BPM = false;
                        try
                        {
                            if (vitaldata != null)
                            {
                                if (int.Parse(vitaldata.Pulse) >= 70)
                                {
                                    hasAbove70BPM = true;
                                }
                            }
                        }
                        catch (Exception ex) { }
                        if (hasAbove70BPM &&
                                IsPrescribed(MedicationClass.Beta_blocker) &&
                                //AtMaximumTherapy(MedicationClass.Beta_blocker)
                                (ret_Beta.IsMaxDose || ret_Beta.IsDoseMax == 1)
                                && (HasMedicalHistoryType("Atrial fibrillation / flutter") || HasMedicalHistoryType("Arrhythmia - Atrial fibrillation"))
                                )
                        {

                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {

                                SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Blue);
                            }

                        }
                        else if (hasAbove70BPM &&
                                IsPrescribed(MedicationClass.Beta_blocker) &&
                               //  AtMaximumTherapy(MedicationClass.Beta_blocker)
                               (ret_Beta.IsMaxDose || ret_Beta.IsDoseMax == 1)
                                && (!HasMedicalHistoryType("Atrial fibrillation / flutter") && !HasMedicalHistoryType("Arrhythmia - Atrial fibrillation"))
                                && HasMedicalHistoryType("S/P Pacemaker"))
                        {
                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Blue);
                            }

                        }
                        else if (hasAbove70BPM &&
                                IsPrescribed(MedicationClass.Beta_blocker) &&
                               //  AtMaximumTherapy(MedicationClass.Beta_blocker) &&
                               (ret_Beta.IsMaxDose || ret_Beta.IsDoseMax == 1) &&
                                (!HasMedicalHistoryType("Atrial fibrillation / flutter") && !HasMedicalHistoryType("Arrhythmia - Atrial fibrillation"))
                                && !HasMedicalHistoryType("S/P Pacemaker"))
                        {
                            SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Red);

                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                if (ret.IsDoseMax == 1)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Green);
                                }
                                else if (ret.IsDoseMax == 0)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Yellow);
                                }
                            }
                        }
                        else
                        {
                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.None);
                            }
                        }

                    }
                    else if (IsContraIndicated(MedicationClass.Corlanor))
                    {
                        SetShouldNotPrescribe(MedicationClass.Corlanor);
                    }
                    if ((IsPrescribed(MedicationClass.ACE_inhibitor) && isallegytoace == 0) || (IsPrescribed(MedicationClass.ARB) && isallegytoarb == 0) || isallegytoentresto > 0)
                    {
                        SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);
                    }
                    else if (!IsPrescribed(MedicationClass.ACE_inhibitor) && !IsPrescribed(MedicationClass.ARB) && IsPrescribed(MedicationClass.Entresto) && isallegytoentresto == 0)
                    {
                        var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Entresto);
                        if (medicalData != null &&
                           (medicalData.NYHAClassID == NYHAClassificationType.II ||
                            medicalData.NYHAClassID == NYHAClassificationType.III ||
                            medicalData.NYHAClassID == NYHAClassificationType.IV))
                        {
                            SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Red);

                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                if (ret.IsDoseMax == 1)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Green);
                                }
                                else if (ret.IsDoseMax == 0)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Yellow);
                                }
                            }
                            SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);

                            SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue);

                        }
                        else
                        {
                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.None);
                            }
                            SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);

                            SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue);
                        }

                    }
                    else if (!IsPrescribed(MedicationClass.ACE_inhibitor) && !IsPrescribed(MedicationClass.ARB) && CanPrescribe(MedicationClass.Entresto) && isallegytoentresto == 0 && (medicalData != null && medicalData.EjectionFractionPercent < 40))
                    {
                        if (medicalData != null &&
                           (medicalData.NYHAClassID == NYHAClassificationType.II ||
                            medicalData.NYHAClassID == NYHAClassificationType.III ||
                            medicalData.NYHAClassID == NYHAClassificationType.IV))
                        {
                            SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Red);
                            var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Entresto);
                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                if (ret.IsDoseMax == 1)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Green);
                                }
                                else if (ret.IsDoseMax == 0)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Yellow);
                                }
                            }
                        }
                        else
                        {
                            SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.None);
                        }

                    }
                    else if (IsContraIndicated(MedicationClass.Entresto))
                    {
                        SetShouldNotPrescribe(MedicationClass.Entresto);
                    }

                    else
                    {
                        if (medicalData != null &&
                           (medicalData.NYHAClassID == NYHAClassificationType.II ||
                            medicalData.NYHAClassID == NYHAClassificationType.III ||
                            medicalData.NYHAClassID == NYHAClassificationType.IV) && medicalData.EjectionFractionPercent < 40)
                        {
                            SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Red);
                            var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Entresto);
                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                if (ret.IsDoseMax == 1)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Green);
                                }
                                else if (ret.IsDoseMax == 0)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Yellow);
                                }
                            }
                        }
                        else
                        {
                            if (medicalData != null && medicalData.EjectionFractionPercent < 40)
                            {
                                SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.None);
                            }

                        }
                    }

                    if (isallegytodixo > 0)
                    {
                        SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.Blue);
                    }
                    else if ((IsPrescribed(MedicationClass.Digoxin)) && isallegytodixo == 0)
                    {
                        var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Digoxin);
                        var vitaldata = vitalSigns.OrderByDescending(x => x.CreationDate).FirstOrDefault();
                        var hasAbove60BPM = false;
                        try
                        {
                            if (int.Parse(vitaldata.Pulse) > 60)
                            {
                                hasAbove60BPM = true;
                            }
                        }
                        catch (Exception ex) { }
                        if (( //AtMaximumTherapy(MedicationClass.ACE_inhibitor) ||
                              //    AtMaximumTherapy(MedicationClass.ARB) ||
                              //    AtMaximumTherapy(MedicationClass.Entresto)
                         ret_ACE.IsMaxDose || ret_ACE.IsDoseMax == 1 || ret_ARB.IsMaxDose || ret_ARB.IsDoseMax == 1 || ret_Entresto.IsMaxDose || ret_Entresto.IsDoseMax == 1
                             ))

                        {
                            if (//AtMaximumTherapy(MedicationClass.Beta_blocker)  //&&
                                (ret_Beta.IsMaxDose || ret_Beta.IsDoseMax == 1)
                                //AtMaximumTherapy(MedicationClass.Hydralazine) &&
                                //AtMaximumTherapy(MedicationClass.Corlanor)
                                && medicalData != null &&
                               (//medicalData.NYHAClassID == NYHAClassificationType.II || as per rule no 9
                                medicalData.NYHAClassID == NYHAClassificationType.III ||
                                medicalData.NYHAClassID == NYHAClassificationType.IV) &&
                                hasAbove60BPM
                                )
                            {
                                if ((ret_aldo.IsMaxDose || ret_aldo.IsDoseMax == 1) &&
                                //AtMaximumTherapy(MedicationClass.Aldosterone_antagonist) //&&
                                //AtMaximumTherapy(MedicationClass.Hydralazine) &&
                                //AtMaximumTherapy(MedicationClass.Corlanor)
                                //&&
                                    medicalData != null &&
                               (//medicalData.NYHAClassID == NYHAClassificationType.II || as per rule no 9
                                medicalData.NYHAClassID == NYHAClassificationType.III ||
                                medicalData.NYHAClassID == NYHAClassificationType.IV) &&
                                hasAbove60BPM
                                )
                                {
                                    SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.Red);

                                    if (ret.IsMaxDose)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else
                                    {
                                        if (ret.IsDoseMax == 1)
                                        {
                                            SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.Green);
                                        }
                                        else if (ret.IsDoseMax == 0)
                                        {
                                            SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.Yellow);
                                        }
                                    }
                                }
                                else
                                {
                                    if (ret.IsMaxDose)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.None);
                                    }
                                }
                            }
                            else
                            {
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.None);
                                }
                            }
                        }
                        else
                        {
                            if (ret.IsMaxDose)
                            {
                                SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.Green);
                            }
                            else
                            {
                                SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.None);
                            }
                        }

                    }
                    //else if (CanPrescribe(MedicationClass.Digoxin))
                    //{
                    //    var hasAbove60BPM = vitalSigns.Any(x => !x.Pulse.Equals("N/A", StringComparison.OrdinalIgnoreCase) && int.Parse(x.Pulse) > 60);

                    //    if ((AtMaximumTherapy(MedicationClass.ACE_inhibitor) ||
                    //        AtMaximumTherapy(MedicationClass.ARB) ||
                    //        AtMaximumTherapy(MedicationClass.Entresto)) &&
                    //        AtMaximumTherapy(MedicationClass.Beta_blocker) &&
                    //        AtMaximumTherapy(MedicationClass.Aldosterone_antagonist) //&&
                    //                                                                 //AtMaximumTherapy(MedicationClass.Hydralazine) &&
                    //                                                                 //AtMaximumTherapy(MedicationClass.Corlanor)
                    //        && medicalData != null &&
                    //       (//medicalData.NYHAClassID == NYHAClassificationType.II || as per rule no 9
                    //        medicalData.NYHAClassID == NYHAClassificationType.III ||
                    //        medicalData.NYHAClassID == NYHAClassificationType.IV) &&
                    //        hasAbove60BPM
                    //        )
                    //    {
                    //        SetShouldPrescribe(MedicationClass.Digoxin);
                    //    }
                    //    else
                    //    {
                    //        SetShouldNotPrescribe(MedicationClass.Digoxin);
                    //    }
                    //}
                    else if (IsContraIndicated(MedicationClass.Digoxin))
                    {
                        SetShouldNotPrescribe(MedicationClass.Digoxin);
                    }


                    #endregion
                }
                SetShouldNotPrescribe(MedicationClass.Other).DivColor = GetColor(MedicationScale.None);

            }

            return meds;
        }

        public Result DeleteMedicationDataRest(string patientid, string medicationID)
        {
            Result res = new Result();
            try
            {
                PatientMedicationQO medQO = new PatientMedicationQO();
                medQO.ID = Guid.Parse(medicationID);
                DeletePatientMedication(medQO);
                res.Status = "1";
                res.Message = "Success";
            }
            catch (Exception ex)
            {
                res.Status = "0";
                res.Message = "Please contact administrator.";
            }

            return res;

        }

        public DailReportResults GetPatientDailyVitalRest(string id, string pid)
        {
            DailReportResults res = new DailReportResults();
            try
            {
                var report = GetPatientReportWithVitalsRest(Guid.Parse(id), Guid.Parse(pid));

                //var sortedEnumerable = report.OrderByDescending(w => w.VitalDate);
                //report = new ObservableCollection<PatientReportWithVitalsRest>(sortedEnumerable);
                int cnt = report.Where(x => x.VerifyVital.ToLower() == "false").Count();
                if (cnt > 0)
                {
                    var sortedEnumerable = report.OrderByDescending(w => Convert.ToDateTime(w.VitalDate));
                    report = new ObservableCollection<PatientReportWithVitalsRest>(sortedEnumerable);
                }
                else
                {
                    var sortedEnumerable = report.OrderBy(w => (w.Name));
                    report = new ObservableCollection<PatientReportWithVitalsRest>(sortedEnumerable);
                }
                ProviderBasicData BasicData = new ProviderBasicData();
                var reportbasic = GetDLPatient().GetProviderBasicData(Guid.Parse(id));
                BasicData.Name = reportbasic.Name;
                BasicData.ProviderName = reportbasic.ProviderName;
                BasicData.NPI = reportbasic.NPI;
                res.BasicData = BasicData;
                res.Status = "1";
                res.Message = "Success";
                res.Record = report.Select(x => new PatientReportWithVitalsRest { Name = x.Name, SignatureDate = x.SignatureDate, DOB = x.DOB, Weight = (x.Weight=="0")?"X": x.Weight, ID = x.ID, VitalID = x.VitalID, ClinicName = x.ClinicName, ProviderName = x.ProviderName, NPI = x.NPI, AlertGenerated = x.AlertGenerated, Pulse = (x.Pulse == "0") ? "X" : x.Pulse, SystolicPressure = (x.SystolicPressure == "0") ? "X" : x.SystolicPressure, DiastolicPressure = (x.DiastolicPressure == "0") ? "X" : x.DiastolicPressure, O2Sat = (x.O2Sat == "0") ? "X" : x.O2Sat, DailyTime = x.DailyTime, VerifyVital = x.VerifyVital, MonthlyTime = x.MonthlyTime, SignatureFile = x.SignatureFile, VitalDate = (Convert.ToDateTime(x.VitalDate).ToString("MM/dd/yyyy")=="01-01-1753" || Convert.ToDateTime(x.VitalDate).ToString("MM/dd/yyyy") == "01/01/1753") ?"": Convert.ToDateTime(x.VitalDate).ToString("MM/dd/yyyy") }).ToList();
            }
            catch (Exception ex)
            {
                res.Status = "0";
                res.Message = "Please contact administrator.";
            }

            return res;

        }
        public static DateTime getServerStandardDateFormat(string serverTime)
        {
            DateTime retDate;
            try
            {
                DateTime dateValue;
                DateTime.TryParse(serverTime, out dateValue);
                return retDate = dateValue;
            }
            catch
            {
                string[] datVal = serverTime.ToString().Replace("-", "/").Split('/');
                return retDate = DateTime.Parse(string.Format("{0}/{1}/{2}", datVal[1].ToString(), datVal[0].ToString(), datVal[2].ToString()));
            }

        }
        public MonthlyReportResults GetPatientMonthlyReport(string id, string aid, string pid, string name, string startdate, string enddate)
        {
            MonthlyReportResults res = new MonthlyReportResults();
            try
            {


                DateTime now = DateTime.Now;
                var startDate1 = new DateTime(now.Year, now.Month, 1);
                var enddate1 = new DateTime(now.Year, now.Month, now.Day);
                startdate = getServerStandardDateFormat(startDate1.ToString()).ToString();
                enddate = getServerStandardDateFormat(enddate1.ToString()).ToString();

                var report = GetPatientReportRest(Guid.Parse(id), startdate, enddate);
                if (name != "Please Select" && aid == "")
                {
                    report = new ObservableCollection<PatientReportRest>(report.Where(x => x.ProviderName == name));
                }
                PatientReportThresholdRest patrpt = new PatientReportThresholdRest();
                patrpt.AboveThreshold = new ObservableCollection<PatientReportRest>(report.Where(m => Convert.ToInt32(m.TotalTime) >= 20).ToList());
                patrpt.BelowThreshold = new ObservableCollection<PatientReportRest>(report.Where(m => Convert.ToInt32(m.TotalTime) < 20).ToList());
                if (report.Count > 0)
                {
                    patrpt.ClinicName = report.FirstOrDefault().ClinicName;
                    patrpt.ProviderName = report.FirstOrDefault().ProviderName;
                    patrpt.NPI = report.FirstOrDefault().NPI;
                    patrpt.MonthReport = startDate1.ToMonthName() + " " + startDate1.Year;
                }
                else {
                    var reportbasic =GetDLPatient().GetProviderBasicData(Guid.Parse(id));
                    patrpt.ClinicName = reportbasic.Name;
                    patrpt.ProviderName = reportbasic.ProviderName;
                    patrpt.NPI = reportbasic.NPI;
                    patrpt.MonthReport = startDate1.ToMonthName() + " " + startDate1.Year;
                }
                res.Status = "1";
                res.Message = "Success";
                res.Record = patrpt;
                // res.Record.AboveThreshold = patrpt.AboveThreshold;
                // res.Record.BelowThreshold = patrpt.BelowThreshold;
            }

            catch (Exception ex)
            {
                res.Status = "0";
                res.Message = "Please contact administrator.";
            }

            return res;

        }

        public MedicationResult GetPatientMedicationRest(PatientMedicationQO medicationQO)
        {
            try
            {
                //var meds = new ObservableCollection<PatientMedication>(GetDLPatient().GetPatientMedication(medicationQO).OrderByDescending(x => x.CreationDate).ToList());
                medicationQO.PageSize = 100;
                var meds = new ObservableCollection<PatientMedication>(GetDLPatient().GetPatientMedication(medicationQO).ToList());
                PatientQO allergyQO = new PatientQO();
                allergyQO.ID = medicationQO.PatientID;
                var allergies = new ObservableCollection<PatientAllergy>(GetDLPatient().GetPatientAllergy(allergyQO).ToList());

                var medsOrig = meds.ToList();

                if (!medicationQO.IsArchivedFL)
                {
                    var inactiveMeds = new ObservableCollection<PatientMedication>(GetDLPatient().GetPatientMedication(new PatientMedicationQO() { PatientID = medicationQO.PatientID, IsArchivedFL = true }).OrderByDescending(x => x.ArchivedDate).ToList());

                    inactiveMeds.ToList().ForEach(x => x.CreationDate = x.ArchivedDate);

                    var patient = GetDLPatient().GetPatientDemographics(new PatientQO() { ID = medicationQO.PatientID });
                    var medicalData = GetPatientMedicalData(new PatientMedicalDataQO() { PatientID = medicationQO.PatientID }).OrderByDescending(x => x.CreationDate).FirstOrDefault();
                    var medicalHistory = GetPatientMedicalHistory(new PatientMedicalHistoryQO() { PatientID = medicationQO.PatientID }).Where(x => x.IsActive == true).ToList();
                    var vitalSigns = GetPatientVitalSigns(new PatientVitalSignsQO() { PatientID = medicationQO.PatientID }, false).ToList();

                    var LuMedicalHistoryType = GetDLLookUp().GetLookUpValues(new MasterLookUpQO()
                    {
                        TableType = LuTableType.LuMedicalHistoryType,
                        OrganizationID = patient.OrganizationID,//GetDLUser().GetUserOrganization(patient.OrganizationID),
                    }).Where(x => x.IsActiveFL == true).ToList();


                    #region function for color
                    Func<MedicationClass, PatientMedication> GetMed = (medClass) =>
                    {
                        var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)medClass);
                        if (ret == null)
                        {
                            ret = new PatientMedication()
                            {
                                MedicationReasonTypeID = (int)MedicationReasonType.Not_currently_prescribed,
                                DivColor = string.Empty,
                                MedicationClassID = (int)medClass,
                            };
                            meds.Add(ret);
                        }
                        else if (ret.MedicationReasonTypeID != (int)MedicationReasonType.None)
                        {

                            if (ret.MedicationReasonTypeID == (int)MedicationReasonType.Allergy_to_Medication)
                            //||
                            //ret.MedicationReasonTypeID == (int)MedicationReasonType.Previous_adverse_reaction_or_intolerance)
                            {
                                if (string.IsNullOrEmpty(ret.DivColor))
                                {
                                    ret.DivColor = GetColor(MedicationScale.Blue);
                                }
                            }
                            //else if (ret.MedicationReasonTypeID == (int)MedicationReasonType.Not_currently_prescribed ||
                            //    ret.MedicationReasonTypeID == (int)MedicationReasonType.Not_indicated_for_this_patient)
                            //{
                            //    if (string.IsNullOrEmpty(ret.DivColor))
                            //    {
                            //        ret.DivColor = GetColor(MedicationScale.Red);
                            //    }
                            //}
                            if (ret.ID != Guid.Empty)
                            {
                                ret.IsDataAdded = true;
                            }
                        }
                        else
                        {
                            if (ret.ID != Guid.Empty)
                            {
                                ret.IsDataAdded = true;
                            }
                        }
                        if (ret.IsDoseMax == 1)
                        {
                            ret.MedicationScaleID = (int)MedicationScale.Green;
                            ret.MedicationReasonTypeID = Int32.MinValue;
                        }
                        else if (ret.IsDoseMax == 0)
                        {
                            ret.MedicationScaleID = (int)MedicationScale.Yellow;
                        }
                        //else
                        //{
                        //    //if (ret.MedicationClassID == (int)MedicationClass.Aldosterone_antagonist)
                        //    //{
                        //    //    ret.MedicationScaleID = (int)MedicationScale.Yellow;
                        //    //}
                        //    if (ret.MedicationClassID == (int)MedicationClass.Diuretic)
                        //    {
                        //        ret.MedicationScaleID = (int)MedicationScale.Green;
                        //    }
                        //}
                        return ret;
                    };

                    Func<MedicationClass, bool> WasPrescribed = (medClass) =>
                    {
                        return inactiveMeds.Any(x => x.MedicationClassID == (int)medClass) ||
                            medsOrig.Any(x =>
                                x.MedicationClassID == (int)medClass &&
                                x.MedicationReasonTypeID == (int)MedicationReasonType.Not_currently_prescribed);
                    };

                    Func<MedicationClass, bool> IsPrescribed = (medClass) =>
                    {
                        return GetMed(medClass).MedicationReasonTypeID == (int)MedicationReasonType.None;
                    };

                    Func<MedicationClass, bool> CanPrescribe = (medClass) =>
                    {
                        return GetMed(medClass).MedicationReasonTypeID == (int)MedicationReasonType.Not_currently_prescribed;
                    };

                    Func<MedicationClass, bool> IsIntolerant = (medClass) =>
                    {
                        return GetMed(medClass).MedicationReasonTypeID == (int)MedicationReasonType.Previous_adverse_reaction_or_intolerance;
                    };

                    Func<MedicationClass, bool> IsAllergic = (medClass) =>
                    {
                        return GetMed(medClass).MedicationReasonTypeID == (int)MedicationReasonType.Allergy_to_Medication;
                    };

                    Func<MedicationClass, bool> IsContraIndicated = (medClass) =>
                    {
                        return IsIntolerant(medClass) || IsAllergic(medClass);
                    };

                    Action<MedicationClass> SetShouldPrescribe = (medClass) =>
                    {
                        GetMed(medClass).DivColor = "redDiv";
                    };

                    Func<MedicationClass, PatientMedication> SetShouldNotPrescribe = (medClass) =>
                    {
                        var med = GetMed(medClass);
                        int isallegy1 = 0;
                        var allergy1 = allergies.FirstOrDefault(m => m.Name == medClass.ToString());
                        if (allergy1 != null)
                        {
                            isallegy1 = 1;
                        }
                        if (IsAllergic(medClass) || isallegy1 > 0)
                        {
                            med.MedicationScaleID = (int)MedicationScale.Blue;
                            med.DivColor = GetColor(MedicationScale.Blue);
                        }
                        else if (IsIntolerant(medClass))
                        {
                            med.MedicationScaleID = (int)MedicationScale.Blue;
                            med.DivColor = GetColor(MedicationScale.Blue);
                        }
                        else
                        {
                            //if (med.Name == "")
                            //{
                            //    med.DivColor = GetColor(MedicationScale.None);
                            //}
                            if (medClass == MedicationClass.Beta_blocker)
                            {
                                med.MedicationScaleID = (int)MedicationScale.Red;
                                //     med.MedicationReasonTypeID = (int)MedicationReasonType.Not_indicated_for_this_patient;
                                med.DivColor = GetColor(MedicationScale.Red);
                            }

                        }
                        return med;
                    };

                    Func<string, int> GetLuMedicalHistoryTypeID = (name) =>
                    {
                        int ret = Int32.MinValue;
                        var item = LuMedicalHistoryType.FirstOrDefault(x => x.IsActiveFL && x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                        if (item != null)
                        {
                            ret = item.ID;
                        }
                        return ret;
                    };

                    Func<string, bool> HasMedicalHistoryType = (historyTypeName) =>
                    {
                        var arrhythmiaID = GetLuMedicalHistoryTypeID(historyTypeName);

                        return medicalHistory.Any(x => x.MedicalHistoryTypeID == arrhythmiaID);
                    };
                    Func<string, bool> HasICDMedicalHistoryType = (historyTypeName) =>
                    {


                        return medicalHistory.Any(x => x.ICDDeviceTypeName == historyTypeName);
                    };

                    Func<MedicationClass, bool> AtMaximumTherapy = (medClass) =>
                    {
                        return (IsPrescribed(medClass) && GetMed(medClass).MedicationScaleID == (int)MedicationScale.Green);// || !CanPrescribe(medClass);
                    };
                    #endregion
                    bool is_flag = false;
                    bool is_meddata = false;
                    foreach (MedicationClass val in Enum.GetValues(typeof(MedicationClass)))
                    {
                        var med = GetMed(val);
                        if (med.MedicationClassName != "")
                        {
                            is_meddata = true;
                        }
                        if (string.IsNullOrEmpty(med.DivColor))
                        {
                            med.DivColor = GetColor((MedicationScale)med.MedicationScaleID);
                        }
                        if (val == MedicationClass.ACE_inhibitor && med.ID != Guid.Empty)
                        {
                            is_flag = true;
                            med.DivColor = GetColor(MedicationScale.Red);
                            if (IsPrescribed(MedicationClass.ACE_inhibitor))
                            {

                                SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);
                                SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);
                            }
                            if (IsAllergic(MedicationClass.ACE_inhibitor))
                            {

                                med.DivColor = GetColor(MedicationScale.Blue);
                            }
                        }
                        if (val == MedicationClass.ARB && med.ID != Guid.Empty)
                        {
                            is_flag = true;
                            med.DivColor = GetColor(MedicationScale.Red);
                            if (IsPrescribed(MedicationClass.ARB))
                            {

                                SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue);
                                SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);
                            }
                            if (IsAllergic(MedicationClass.ARB))
                            {

                                med.DivColor = GetColor(MedicationScale.Blue);
                            }
                        }
                        if (val == MedicationClass.Entresto && med.ID != Guid.Empty)
                        {
                            is_flag = true;
                        }
                        if (med.IsDoseMax == 1)
                        {
                            med.DivColor = GetColor(MedicationScale.Green);
                        }
                        if (med.IsDoseMax == 0)
                        {
                            med.DivColor = GetColor(MedicationScale.Yellow);
                        }
                        int isallegy = 0;

                        var allergy2 = allergies.FirstOrDefault(m => m.ClassID == med.MedicationClassID);
                        if (med.MedicationClassID == 7)
                        {
                            allergy2 = null;
                        }
                        if (allergy2 != null)
                        {

                            isallegy = 1;
                        }
                        if (isallegy > 0)
                        {
                            med.MedicationScaleID = (int)MedicationScale.Blue;
                            med.DivColor = GetColor(MedicationScale.Blue);
                        }

                    }
                    if (!is_flag)
                    {
                        if (!is_meddata && medicalData == null && (vitalSigns == null || vitalSigns.Count == 0) && (medicalHistory == null || medicalHistory.Count == 0) && (allergies == null || allergies.Count == 0))
                        {
                            is_flag = false;
                            SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.None);
                            SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.None);
                            SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.None);
                        }
                        else
                        {
                            is_flag = true;
                            SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Red);
                            SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Red);
                            SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Red);
                        }
                    }

                    //if (!IsPrescribed(MedicationClass.Entresto))
                    //{
                    //    SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);
                    //}
                    //if (!IsPrescribed(MedicationClass.ARB) && !IsPrescribed(MedicationClass.ACE_inhibitor) && IsPrescribed(MedicationClass.Entresto))
                    //{
                    //    SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);
                    //    SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue);
                    //}
                    #region allergies
                    int isallegytoarb = 0;
                    int isallegytoentresto = 0;
                    int isallegytoace = 0;
                    int isallegytobeta = 0;
                    int isallegytodixo = 0;
                    int isallegytoaldo = 0;
                    int isallegytohydral = 0;
                    int isallegytohydiur = 0;
                    int isallegytocorl = 0;
                    var allergy = allergies.FirstOrDefault(m => m.ClassID == (int)MedicationClass.ARB);
                    if (allergy != null)
                    {
                        isallegytoarb = 1;
                    }
                    allergy = allergies.FirstOrDefault(m => m.ClassID == (int)MedicationClass.Corlanor);
                    if (allergy != null)
                    {
                        isallegytocorl = 1;
                    }
                    allergy = allergies.FirstOrDefault(m => m.ClassID == (int)MedicationClass.ACE_inhibitor);
                    if (allergy != null)
                    {
                        isallegytoace = 1;
                    }
                    allergy = allergies.FirstOrDefault(m => m.ClassID == (int)MedicationClass.Entresto);
                    if (allergy != null)
                    {
                        isallegytoentresto = 1;
                    }
                    allergy = allergies.FirstOrDefault(m => m.ClassID == (int)MedicationClass.Beta_blocker);
                    if (allergy != null)
                    {
                        isallegytobeta = 1;
                    }
                    allergy = allergies.FirstOrDefault(m => m.ClassID == (int)MedicationClass.Hydralazine);
                    if (allergy != null)
                    {
                        isallegytohydral = 1;
                    }
                    allergy = allergies.FirstOrDefault(m => m.ClassID == (int)MedicationClass.Aldosterone_antagonist);
                    if (allergy != null)
                    {
                        isallegytoaldo = 1;
                    }
                    allergy = allergies.FirstOrDefault(m => m.ClassID == (int)MedicationClass.Digoxin);
                    if (allergy != null)
                    {
                        isallegytodixo = 1;
                    }
                    allergy = allergies.FirstOrDefault(m => m.ClassID == (int)MedicationClass.Diuretic);
                    if (allergy != null)
                    {
                        isallegytohydiur = 1;
                    }
                    #endregion
                    if (!IsPrescribed(MedicationClass.Diuretic) && !IsAllergic(MedicationClass.Diuretic) && isallegytohydiur == 0)
                    {
                        SetShouldNotPrescribe(MedicationClass.Diuretic).DivColor = GetColor(MedicationScale.None);


                    }
                    else if (IsAllergic(MedicationClass.Diuretic) || isallegytohydiur > 0)
                    {
                        SetShouldNotPrescribe(MedicationClass.Diuretic).DivColor = GetColor(MedicationScale.Blue);
                    }
                    else if (IsPrescribed(MedicationClass.Diuretic) && isallegytohydiur == 0)
                    {
                        SetShouldNotPrescribe(MedicationClass.Diuretic).DivColor = GetColor(MedicationScale.Green);
                    }
                    if (is_flag)
                    {
                        var ret_ARB = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.ARB);
                        var ret_Beta = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Beta_blocker);
                        var ret_ACE = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.ACE_inhibitor);
                        var ret_Entresto = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Entresto);
                        var ret_aldo = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Aldosterone_antagonist);
                        #region color codes
                        if (medicalData != null && medicalData.EjectionFractionPercent >= 40)
                        {
                            //if (HasMedicalHistoryType("Hypertension"))
                            //{
                            //SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.None);
                            if (IsPrescribed(MedicationClass.ACE_inhibitor) && isallegytoace == 0)
                            {
                                //if (IsPrescribed(MedicationClass.ARB))
                                //{ SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue); }
                                //else
                                //{
                                SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);
                                //}
                                SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);
                                SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Red);
                                var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.ACE_inhibitor);
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    if (ret.IsDoseMax == 1)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else if (ret.IsDoseMax == 0)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Yellow);
                                    }
                                }
                            }
                            else if (CanPrescribe(MedicationClass.ACE_inhibitor) && isallegytoace == 0)
                            {
                                //if (IsPrescribed(MedicationClass.ARB))
                                //{ SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue); }
                                //else
                                //{
                                //SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);
                                //}
                                //SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);
                                SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Red);
                                var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.ACE_inhibitor);
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    if (ret.IsDoseMax == 1)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else if (ret.IsDoseMax == 0)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Yellow);
                                    }
                                }
                            }
                            else if (IsAllergic(MedicationClass.ACE_inhibitor) || isallegytoace > 0)
                            {
                                SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue);

                            }
                            else
                            {
                                SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.None);
                            }
                            if (!IsPrescribed(MedicationClass.ACE_inhibitor) && IsPrescribed(MedicationClass.ARB) && isallegytoarb == 0)
                            {
                                SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue);
                                SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);
                                SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Red);
                                var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.ARB);
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    if (ret.IsDoseMax == 1)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else if (ret.IsDoseMax == 0)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Yellow);
                                    }
                                }
                            }
                            else if ((!IsPrescribed(MedicationClass.ACE_inhibitor) || isallegytoace > 0) && CanPrescribe(MedicationClass.ARB) && isallegytoarb == 0)
                            {
                                SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Red);
                                var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.ARB);
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    if (ret.IsDoseMax == 1)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else if (ret.IsDoseMax == 0)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Yellow);
                                    }
                                }
                            }
                            else if ((IsPrescribed(MedicationClass.ACE_inhibitor) && isallegytoace == 0) || IsAllergic(MedicationClass.ARB) || isallegytoarb > 0)
                            {
                                SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);

                            }
                            //else
                            //{
                            //    SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.None);
                            //}
                            if (IsPrescribed(MedicationClass.Beta_blocker) && isallegytobeta == 0)
                            {
                                SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Red);
                                var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Beta_blocker);
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    if (ret.IsDoseMax == 1)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else if (ret.IsDoseMax == 0)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Yellow);
                                    }
                                }
                            }
                            else if (CanPrescribe(MedicationClass.Beta_blocker) && isallegytobeta == 0)
                            {
                                SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Red);
                                var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Beta_blocker);
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    if (ret.IsDoseMax == 1)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else if (ret.IsDoseMax == 0)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Yellow);
                                    }
                                }
                            }
                            else if (IsAllergic(MedicationClass.Beta_blocker) || isallegytobeta > 0)
                            {
                                SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Blue);

                            }
                            else
                            {
                                SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.None);
                            }
                            //}

                            if (CanPrescribe(MedicationClass.Entresto))
                            {
                                SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);
                            }
                            SetShouldNotPrescribe(MedicationClass.Other).DivColor = GetColor(MedicationScale.None);

                        }
                        else
                        {
                            //if (is_flag)
                            //{
                            if (IsPrescribed(MedicationClass.ACE_inhibitor) && isallegytoace == 0)
                            {
                                SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Red);
                                var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.ACE_inhibitor);
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    if (ret.IsDoseMax == 1)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else if (ret.IsDoseMax == 0)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Yellow);
                                    }
                                }
                                SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);

                                SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);

                            }
                            else if (CanPrescribe(MedicationClass.ACE_inhibitor) && isallegytoace == 0)
                            {
                                SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Red);

                            }
                            else
                            {
                                if (IsContraIndicated(MedicationClass.ACE_inhibitor))
                                {
                                    SetShouldNotPrescribe(MedicationClass.ACE_inhibitor);

                                    //if (CanPrescribe(MedicationClass.ARB))
                                    //{
                                    //    SetShouldPrescribe(MedicationClass.ARB);
                                    //}
                                    //else if (IsContraIndicated(MedicationClass.ARB))
                                    //{
                                    //    SetShouldNotPrescribe(MedicationClass.ARB);
                                    //}
                                }
                                else
                                {
                                    if (IsContraIndicated(MedicationClass.ARB))
                                    {
                                        //if (CanPrescribe(MedicationClass.Hydralazine))
                                        //{
                                        //    SetShouldPrescribe(MedicationClass.Hydralazine);
                                        //}
                                        //else 
                                        if (IsContraIndicated(MedicationClass.Hydralazine))
                                        {
                                            SetShouldNotPrescribe(MedicationClass.Hydralazine);
                                        }
                                    }
                                    else
                                    {
                                        if (IsPrescribed(MedicationClass.ACE_inhibitor))
                                        {
                                            //if (CanPrescribe(MedicationClass.ARB))
                                            //{
                                            //    SetShouldNotPrescribe(MedicationClass.ARB);
                                            //}
                                            //else {
                                            //    SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);
                                            //}
                                            if (IsPrescribed(MedicationClass.ARB))
                                            { SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue); }
                                            else
                                            {
                                                SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);
                                            }
                                            SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);
                                        }
                                        else
                                        {
                                            if (isallegytoace > 0 || IsAllergic(MedicationClass.ACE_inhibitor))
                                            {
                                                SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue);
                                            }
                                            //if (CanPrescribe(MedicationClass.ARB))
                                            //{
                                            //    SetShouldPrescribe(MedicationClass.ARB);
                                            //}
                                        }
                                    }
                                }
                            }
                            if (!IsPrescribed(MedicationClass.ACE_inhibitor) && IsPrescribed(MedicationClass.ARB) && isallegytoarb == 0)
                            {
                                SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Red);
                                var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.ARB);
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    if (ret.IsDoseMax == 1)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else if (ret.IsDoseMax == 0)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Yellow);
                                    }
                                }

                                SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue);

                                SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);

                            }
                            else if ((!IsPrescribed(MedicationClass.ACE_inhibitor) || isallegytoace > 0) && CanPrescribe(MedicationClass.ARB) && isallegytoarb == 0)
                            {
                                SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Red);


                            }
                            else if (IsPrescribed(MedicationClass.ACE_inhibitor) || isallegytoarb > 0)
                            {
                                SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);
                            }

                            //}
                            //if (CanPrescribe(MedicationClass.Beta_blocker))
                            //{
                            //    SetShouldPrescribe(MedicationClass.Beta_blocker);
                            //}
                            //else if (IsContraIndicated(MedicationClass.Beta_blocker))
                            //{
                            //    SetShouldNotPrescribe(MedicationClass.Beta_blocker);
                            //}
                            //else
                            if ((IsPrescribed(MedicationClass.Beta_blocker) || CanPrescribe(MedicationClass.Beta_blocker)) && isallegytobeta == 0)
                            {
                                SetShouldNotPrescribe(MedicationClass.Beta_blocker);
                                var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Beta_blocker);
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    if (ret.IsDoseMax == 1)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else if (ret.IsDoseMax == 0)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Yellow);
                                    }
                                }
                            }
                            else if (isallegytobeta > 0)
                            {
                                SetShouldNotPrescribe(MedicationClass.Beta_blocker).DivColor = GetColor(MedicationScale.Blue);
                            }

                        }
                        if ((IsPrescribed(MedicationClass.Aldosterone_antagonist) || CanPrescribe(MedicationClass.Aldosterone_antagonist)) && isallegytoaldo == 0)
                        {
                            var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Aldosterone_antagonist);
                            if (medicalData != null &&
                                (/*medicalData.NYHAClassID == NYHAClassificationType.II || acc to rule no 5*/
                                medicalData.NYHAClassID == NYHAClassificationType.III ||
                                medicalData.NYHAClassID == NYHAClassificationType.IV))
                            {
                                //Is the patients gfr>30 ml/min and potassium <5.0mEq/dl
                                SetShouldNotPrescribe(MedicationClass.Aldosterone_antagonist).DivColor = GetColor(MedicationScale.Red);

                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Aldosterone_antagonist).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    if (ret.IsDoseMax == 1)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Aldosterone_antagonist).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else if (ret.IsDoseMax == 0)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Aldosterone_antagonist).DivColor = GetColor(MedicationScale.Yellow);
                                    }
                                }
                            }
                            else
                            {
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Aldosterone_antagonist).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    SetShouldNotPrescribe(MedicationClass.Aldosterone_antagonist).DivColor = GetColor(MedicationScale.None);
                                }
                            }


                        }

                        else if (IsContraIndicated(MedicationClass.Aldosterone_antagonist))
                        {
                            SetShouldNotPrescribe(MedicationClass.Aldosterone_antagonist);
                        }
                        else if (isallegytoaldo > 0)
                        {
                            SetShouldNotPrescribe(MedicationClass.Aldosterone_antagonist).DivColor = GetColor(MedicationScale.Blue);
                        }


                        if (isallegytohydral > 0)
                        {

                            SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Blue);
                        }
                        else if ((IsPrescribed(MedicationClass.Hydralazine) || CanPrescribe(MedicationClass.Hydralazine)) && isallegytohydral == 0)
                        {
                            var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Hydralazine);
                            if (
                                medicalData != null

                                 && //(AtMaximumTherapy(MedicationClass.ACE_inhibitor) || AtMaximumTherapy(MedicationClass.ARB) || AtMaximumTherapy(MedicationClass.Entresto))
                                 (ret_ACE.IsMaxDose || ret_ACE.IsDoseMax == 1 || ret_ARB.IsMaxDose || ret_ARB.IsDoseMax == 1 || ret_Entresto.IsDoseMax == 1 || ret_Entresto.IsMaxDose)
                                 )
                            {
                                SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Red);

                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    if (ret.IsDoseMax == 1)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else if (ret.IsDoseMax == 0)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Yellow);
                                    }
                                }
                                if (patient.RaceID == RaceType.Black_or_African_American && (medicalData.NYHAClassID == NYHAClassificationType.III ||
                                 medicalData.NYHAClassID == NYHAClassificationType.IV))
                                {
                                    SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Red);
                                    if (ret.IsMaxDose)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else
                                    {
                                        if (ret.IsDoseMax == 1)
                                        {
                                            SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Green);
                                        }
                                        else if (ret.IsDoseMax == 0)
                                        {
                                            SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Yellow);
                                        }
                                    }
                                }
                                else if (patient.RaceID == RaceType.Black_or_African_American && (medicalData.NYHAClassID == NYHAClassificationType.I ||
                                 medicalData.NYHAClassID == NYHAClassificationType.II))
                                {
                                    SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.None);
                                }


                            }

                            else
                            {
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    SetShouldNotPrescribe(MedicationClass.Hydralazine).DivColor = GetColor(MedicationScale.None);
                                }
                            }
                        }
                        else if (IsContraIndicated(MedicationClass.Hydralazine))
                        {
                            SetShouldNotPrescribe(MedicationClass.Hydralazine);
                        }

                        if (isallegytocorl > 0)
                        {
                            SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Blue);
                        }
                        else if ((IsPrescribed(MedicationClass.Corlanor)) && isallegytocorl == 0)
                        {
                            var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Corlanor);
                            //var hasAbove70BPM = vitalSigns.Any(x => !x.Pulse.Equals("N/A", StringComparison.OrdinalIgnoreCase) && int.Parse(x.Pulse) >= 70);
                            var vitaldata = vitalSigns.OrderByDescending(x => x.CreationDate).FirstOrDefault();
                            var hasAbove70BPM = false;
                            try
                            {
                                if (int.Parse(vitaldata.Pulse) >= 70)
                                {
                                    hasAbove70BPM = true;
                                }
                            }
                            catch (Exception ex) { }
                            if (hasAbove70BPM &&
                                    IsPrescribed(MedicationClass.Beta_blocker) &&
                                    //AtMaximumTherapy(MedicationClass.Beta_blocker)
                                    (ret_Beta.IsMaxDose || ret_Beta.IsDoseMax == 1)
                                    && (HasMedicalHistoryType("Atrial fibrillation / flutter") || HasMedicalHistoryType("Arrhythmia - Atrial fibrillation"))
                                    )
                            {

                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {

                                    SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Blue);
                                }

                            }
                            else if (hasAbove70BPM &&
                                    IsPrescribed(MedicationClass.Beta_blocker) &&
                                   //  AtMaximumTherapy(MedicationClass.Beta_blocker)
                                   (ret_Beta.IsMaxDose || ret_Beta.IsDoseMax == 1)
                                    && (!HasMedicalHistoryType("Atrial fibrillation / flutter") && !HasMedicalHistoryType("Arrhythmia - Atrial fibrillation"))
                                    && HasMedicalHistoryType("S/P Pacemaker"))
                            {
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Blue);
                                }

                            }
                            else if (hasAbove70BPM &&
                                    IsPrescribed(MedicationClass.Beta_blocker) &&
                                   //  AtMaximumTherapy(MedicationClass.Beta_blocker) &&
                                   (ret_Beta.IsMaxDose || ret_Beta.IsDoseMax == 1) &&
                                    (!HasMedicalHistoryType("Atrial fibrillation / flutter") && !HasMedicalHistoryType("Arrhythmia - Atrial fibrillation"))
                                    && !HasMedicalHistoryType("S/P Pacemaker"))
                            {
                                SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Red);

                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    if (ret.IsDoseMax == 1)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else if (ret.IsDoseMax == 0)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Yellow);
                                    }
                                }
                            }
                            else
                            {
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    SetShouldNotPrescribe(MedicationClass.Corlanor).DivColor = GetColor(MedicationScale.None);
                                }
                            }

                        }
                        else if (IsContraIndicated(MedicationClass.Corlanor))
                        {
                            SetShouldNotPrescribe(MedicationClass.Corlanor);
                        }
                        if ((IsPrescribed(MedicationClass.ACE_inhibitor) && isallegytoace == 0) || (IsPrescribed(MedicationClass.ARB) && isallegytoarb == 0) || isallegytoentresto > 0)
                        {
                            SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Blue);
                        }
                        else if (!IsPrescribed(MedicationClass.ACE_inhibitor) && !IsPrescribed(MedicationClass.ARB) && IsPrescribed(MedicationClass.Entresto) && isallegytoentresto == 0)
                        {
                            var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Entresto);
                            if (medicalData != null &&
                               (medicalData.NYHAClassID == NYHAClassificationType.II ||
                                medicalData.NYHAClassID == NYHAClassificationType.III ||
                                medicalData.NYHAClassID == NYHAClassificationType.IV))
                            {
                                SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Red);

                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    if (ret.IsDoseMax == 1)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else if (ret.IsDoseMax == 0)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Yellow);
                                    }
                                }
                                SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);

                                SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue);

                            }
                            else
                            {
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.None);
                                }
                                SetShouldNotPrescribe(MedicationClass.ARB).DivColor = GetColor(MedicationScale.Blue);

                                SetShouldNotPrescribe(MedicationClass.ACE_inhibitor).DivColor = GetColor(MedicationScale.Blue);
                            }

                        }
                        else if (!IsPrescribed(MedicationClass.ACE_inhibitor) && !IsPrescribed(MedicationClass.ARB) && CanPrescribe(MedicationClass.Entresto) && isallegytoentresto == 0 && (medicalData != null && medicalData.EjectionFractionPercent < 40))
                        {
                            if (medicalData != null &&
                               (medicalData.NYHAClassID == NYHAClassificationType.II ||
                                medicalData.NYHAClassID == NYHAClassificationType.III ||
                                medicalData.NYHAClassID == NYHAClassificationType.IV))
                            {
                                SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Red);
                                var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Entresto);
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    if (ret.IsDoseMax == 1)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else if (ret.IsDoseMax == 0)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Yellow);
                                    }
                                }
                            }
                            else
                            {
                                SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.None);
                            }

                        }
                        else if (IsContraIndicated(MedicationClass.Entresto))
                        {
                            SetShouldNotPrescribe(MedicationClass.Entresto);
                        }

                        else
                        {
                            if (medicalData != null &&
                               (medicalData.NYHAClassID == NYHAClassificationType.II ||
                                medicalData.NYHAClassID == NYHAClassificationType.III ||
                                medicalData.NYHAClassID == NYHAClassificationType.IV) && medicalData.EjectionFractionPercent < 40)
                            {
                                SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Red);
                                var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Entresto);
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    if (ret.IsDoseMax == 1)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else if (ret.IsDoseMax == 0)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.Yellow);
                                    }
                                }
                            }
                            else
                            {
                                if (medicalData != null && medicalData.EjectionFractionPercent < 40)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Entresto).DivColor = GetColor(MedicationScale.None);
                                }

                            }
                        }

                        if (isallegytodixo > 0)
                        {
                            SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.Blue);
                        }
                        else if ((IsPrescribed(MedicationClass.Digoxin)) && isallegytodixo == 0)
                        {
                            var ret = meds.FirstOrDefault(x => x.MedicationClassID == (int)MedicationClass.Digoxin);
                            var vitaldata = vitalSigns.OrderByDescending(x => x.CreationDate).FirstOrDefault();
                            var hasAbove60BPM = false;
                            try
                            {
                                if (int.Parse(vitaldata.Pulse) > 60)
                                {
                                    hasAbove60BPM = true;
                                }
                            }
                            catch (Exception ex) { }
                            if (( //AtMaximumTherapy(MedicationClass.ACE_inhibitor) ||
                                  //    AtMaximumTherapy(MedicationClass.ARB) ||
                                  //    AtMaximumTherapy(MedicationClass.Entresto)
                             ret_ACE.IsMaxDose || ret_ACE.IsDoseMax == 1 || ret_ARB.IsMaxDose || ret_ARB.IsDoseMax == 1 || ret_Entresto.IsMaxDose || ret_Entresto.IsDoseMax == 1
                                 ))

                            {
                                if (//AtMaximumTherapy(MedicationClass.Beta_blocker)  //&&
                                    (ret_Beta.IsMaxDose || ret_Beta.IsDoseMax == 1)
                                    //AtMaximumTherapy(MedicationClass.Hydralazine) &&
                                    //AtMaximumTherapy(MedicationClass.Corlanor)
                                    && medicalData != null &&
                                   (//medicalData.NYHAClassID == NYHAClassificationType.II || as per rule no 9
                                    medicalData.NYHAClassID == NYHAClassificationType.III ||
                                    medicalData.NYHAClassID == NYHAClassificationType.IV) &&
                                    hasAbove60BPM
                                    )
                                {
                                    if ((ret_aldo.IsMaxDose || ret_aldo.IsDoseMax == 1) &&
                                        //AtMaximumTherapy(MedicationClass.Aldosterone_antagonist) //&&
                                        //AtMaximumTherapy(MedicationClass.Hydralazine) &&
                                        //AtMaximumTherapy(MedicationClass.Corlanor)
                                        //&&
                                        medicalData != null &&
                                   (//medicalData.NYHAClassID == NYHAClassificationType.II || as per rule no 9
                                    medicalData.NYHAClassID == NYHAClassificationType.III ||
                                    medicalData.NYHAClassID == NYHAClassificationType.IV) &&
                                    hasAbove60BPM
                                    )
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.Red);

                                        if (ret.IsMaxDose)
                                        {
                                            SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.Green);
                                        }
                                        else
                                        {
                                            if (ret.IsDoseMax == 1)
                                            {
                                                SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.Green);
                                            }
                                            else if (ret.IsDoseMax == 0)
                                            {
                                                SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.Yellow);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (ret.IsMaxDose)
                                        {
                                            SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.Green);
                                        }
                                        else
                                        {
                                            SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.None);
                                        }
                                    }
                                }
                                else
                                {
                                    if (ret.IsMaxDose)
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.Green);
                                    }
                                    else
                                    {
                                        SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.None);
                                    }
                                }
                            }
                            else
                            {
                                if (ret.IsMaxDose)
                                {
                                    SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.Green);
                                }
                                else
                                {
                                    SetShouldNotPrescribe(MedicationClass.Digoxin).DivColor = GetColor(MedicationScale.None);
                                }
                            }

                        }
                        //else if (CanPrescribe(MedicationClass.Digoxin))
                        //{
                        //    var hasAbove60BPM = vitalSigns.Any(x => !x.Pulse.Equals("N/A", StringComparison.OrdinalIgnoreCase) && int.Parse(x.Pulse) > 60);

                        //    if ((AtMaximumTherapy(MedicationClass.ACE_inhibitor) ||
                        //        AtMaximumTherapy(MedicationClass.ARB) ||
                        //        AtMaximumTherapy(MedicationClass.Entresto)) &&
                        //        AtMaximumTherapy(MedicationClass.Beta_blocker) &&
                        //        AtMaximumTherapy(MedicationClass.Aldosterone_antagonist) //&&
                        //                                                                 //AtMaximumTherapy(MedicationClass.Hydralazine) &&
                        //                                                                 //AtMaximumTherapy(MedicationClass.Corlanor)
                        //        && medicalData != null &&
                        //       (//medicalData.NYHAClassID == NYHAClassificationType.II || as per rule no 9
                        //        medicalData.NYHAClassID == NYHAClassificationType.III ||
                        //        medicalData.NYHAClassID == NYHAClassificationType.IV) &&
                        //        hasAbove60BPM
                        //        )
                        //    {
                        //        SetShouldPrescribe(MedicationClass.Digoxin);
                        //    }
                        //    else
                        //    {
                        //        SetShouldNotPrescribe(MedicationClass.Digoxin);
                        //    }
                        //}
                        else if (IsContraIndicated(MedicationClass.Digoxin))
                        {
                            SetShouldNotPrescribe(MedicationClass.Digoxin);
                        }


                        #endregion
                    }
                    SetShouldNotPrescribe(MedicationClass.Other).DivColor = GetColor(MedicationScale.None);

                }

                MedicationResult res = new MedicationResult();
                res.Status = "1";
                res.Message = "Success";
                var newmeds = meds.Select(x => new PatientMedicationRest { CreationDateLocalTime = x.CreationDateLocalTime.ToString(), LastUpdatedDateLocalTime = x.LastUpdatedDateLocalTime.ToString(), IsTherapy = x.IsTherapy, MedicationClassID = x.MedicationClassID, divColor = x.DivColor, MedicationDoseID = x.MedicationDoseID, ID = x.ID.ToString(), IsMaxDose = x.IsMaxDose, Name = x.Name.ToUpper(), Amount = x.Amount.ToUpper(), Frequency = x.Frequency }).ToList();
                var patientdet = GetPatientDemographics(new PatientQO() { ID = medicationQO.PatientID });
                ObservableCollection<PatientMedicalData> objMedicalData = new ObservableCollection<PatientMedicalData>();
                PatientMedicalDataQO qoObj = new PatientMedicalDataQO() { PatientID = medicationQO.PatientID };
                objMedicalData = GetPatientMedicalData(qoObj);
                PatientHeaderInfoRest objP = new PatientHeaderInfoRest();
                objP.City = (patientdet.Address.City == null) ? "" : patientdet.Address.City;
                objP.Address = (patientdet.Address.Street1 == null) ? "" : patientdet.Address.Street1;
                objP.Zip = (patientdet.Address.Zip.ToString() == null) ? "" : patientdet.Address.Zip.ToString();
                string statename = ((StateType)patientdet.Address.StateID).ToString();
                objP.State = (statename == null) ? "" : statename;
                objP.Age = patientdet.PatientAge.ToString();
                objP.GenderID = patientdet.GenderID.ToString();
                objP.DOB = patientdet.DOB.ToString("MM/dd/yyyy").Replace("-", "/");
                objP.CellPhone = (patientdet.CellPhoneNumber == null) ? "" : patientdet.CellPhoneNumber;
                objP.WorkPhoneNumber = (patientdet.WorkPhoneNumber == null) ? "" : patientdet.WorkPhoneNumber;
                objP.PharmcyPhone = (patientdet.PharmacyPhone == null) ? "" : patientdet.PharmacyPhone;

                string lastsubdate = "";
                PatientVitalSignsQO qoObjvital = new PatientVitalSignsQO() { PatientID = medicationQO.PatientID };
                ObservableCollection<PatientVitalSign> objvitalSigns = new ObservableCollection<PatientVitalSign>();
                objvitalSigns = GetPatientVitalSigns(qoObjvital, false);

                if (objvitalSigns.Count > 0)
                {
                    // CurrentVital = objvitalSigns.First();
                    //---- 27 Aug 2019 -- Patient Dashboard > Blue Boxes of Vital -- do not show vital which are added from CCM Review Page.. so check applied here
                    lastsubdate = objvitalSigns.First(x => x.IsCCM == false).CreationDate.ToString("MM/dd/yyyy HH:mm:ss ttt");
                }
                objP.LastSubmittedVital = lastsubdate.Replace("-", "/");
                if (objMedicalData.Count > 0)
                {
                    objP.HFClass = "Stage: " + objMedicalData[0].ACCHeartFailureStageID.ToString() + ", NYHA: " + objMedicalData[0].NYHAClassID.ToString() + ", E.F.: " + Math.Round(objMedicalData[0].EjectionFractionPercent) + "%";
                }
                var maxCreateDt = newmeds.Max(x => x.CreationDateLocalTime);
                var maxUpdateDt = newmeds.Max(x => x.LastUpdatedDateLocalTime);
                if (Convert.ToDateTime(maxUpdateDt) < Convert.ToDateTime(maxCreateDt))
                {
                    maxUpdateDt = maxCreateDt;
                }
                objP.MedicationAsof = "AS OF: " + Convert.ToDateTime(maxUpdateDt).ToString("M-d-yyyy") + " @ " + Convert.ToDateTime(maxUpdateDt).ToString("h:mmtt").ToUpper();
                if (objP.MedicationAsof == "AS OF: 1-1-0001 @ 12:00AM")
                {
                    objP.MedicationAsof = "";
                }
                res.Info = objP;
                PatientMedicationListRest pathhome = new PatientMedicationListRest();
                foreach (PatientMedicationRest pMed in newmeds)
                {
                    PatientMedicationRest obj = new PatientMedicationRest();
                    if (!string.IsNullOrEmpty(pMed.MedicationClassID.ToString()))
                    {
                        obj.Name = pMed.Name;
                        obj.Amount = pMed.Amount;
                        obj.Frequency = pMed.Frequency;
                        obj.divColor = pMed.divColor;
                        obj.MedicationClassID = pMed.MedicationClassID;
                        obj.IsTherapy = pMed.IsTherapy;
                        if (pMed.divColor == "")
                        {
                            obj.divColor = "grayDiv";
                        }
                        if (Convert.ToInt32(pMed.MedicationClassID) == (int)MedicationClass.Diuretic && pathhome.DIURETIC == null)
                        {

                            pathhome.DIURETIC = obj;
                        }
                        if (Convert.ToInt32(pMed.MedicationClassID) == (int)MedicationClass.Digoxin && pathhome.DIGOXIN == null)
                        {

                            pathhome.DIGOXIN = obj;
                        }
                        if (Convert.ToInt32(pMed.MedicationClassID) == (int)MedicationClass.Other && pathhome.OTHER == null)
                        {

                            pathhome.OTHER = obj;
                        }
                        if (Convert.ToInt32(pMed.MedicationClassID) == (int)MedicationClass.Beta_blocker && pathhome.BETA_BLOCKER == null)
                        {

                            pathhome.BETA_BLOCKER = obj;
                        }
                        if (Convert.ToInt32(pMed.MedicationClassID) == (int)MedicationClass.ARB && pathhome.ARB == null)
                        {

                            pathhome.ARB = obj;
                        }
                        if (Convert.ToInt32(pMed.MedicationClassID) == (int)MedicationClass.Aldosterone_antagonist && pathhome.ALDOSTERONE == null)
                        {

                            pathhome.ALDOSTERONE = obj;
                        }
                        if (Convert.ToInt32(pMed.MedicationClassID) == (int)MedicationClass.ACE_inhibitor && pathhome.ACE_INHIBITOR == null)
                        {

                            pathhome.ACE_INHIBITOR = obj;
                        }
                        if (Convert.ToInt32(pMed.MedicationClassID) == (int)MedicationClass.Corlanor && pathhome.CORLANOR == null)
                        {

                            pathhome.CORLANOR = obj;
                        }
                        if (Convert.ToInt32(pMed.MedicationClassID) == (int)MedicationClass.Hydralazine && pathhome.HYDRALAZINE == null)
                        {

                            pathhome.HYDRALAZINE = obj;
                        }
                        if (Convert.ToInt32(pMed.MedicationClassID) == (int)MedicationClass.Entresto && pathhome.ENTRESTO == null)
                        {

                            pathhome.ENTRESTO = obj;
                        }

                    }
                }

                var icdEd = GetDLLookUp().GetICDEducationContent(Int32.MinValue).FirstOrDefault(x => x.IsActiveFL);
                pathhome.ICDEducationContent = "";
                if (icdEd != null)
                {
                    pathhome.ICDEducationContent = icdEd.EducationText ?? "";
                }

                var history = GetPatientMedicalHistory(new PatientMedicalHistoryQO() { PatientID = medicationQO.PatientID });

                pathhome.HasICD = history.Any(x => x.IsActive && string.Compare(x.MedicalHistoryTypeName.ToLower(), "presence of an icd") == 0);
                ICDQueAns QueAns = GetICDQueAns(medicationQO.PatientID);
                PatientMedicalHistoryQO ptMedHistoryQO = new PatientMedicalHistoryQO() { PatientID = medicationQO.PatientID };
                pathhome.ICDDevices = GetDLLookUp().GetLookUpValues(new MasterLookUpQO { TableType = LuTableType.LuICDDeviceType, OrganizationID = patientdet.OrganizationID }).Select(m => new DropdownItemsRecipient { Name = m.Name, ID = m.ID.ToString() }).ToList();
                ObservableCollection<PatientMedicalHistory> objMedicalHistory = new ObservableCollection<PatientMedicalHistory>();
                objMedicalHistory = GetPatientMedicalHistory(ptMedHistoryQO);
                var Top3Rows = objMedicalHistory.Skip<PatientMedicalHistory>(0).Take<PatientMedicalHistory>(3).ToList();
                pathhome.HasICDAns = false;

                pathhome.ICDDeviceOption = GetPatientICDDeviceOption(medicationQO.PatientID);
                if (QueAns != null)
                {
                    if (!string.IsNullOrEmpty(QueAns.IsData))
                    {
                        pathhome.HasICDAns = true;
                    }
                }
                decimal efdata = 0;
                if (objMedicalData != null)
                {
                    if (objMedicalData.Count > 0)
                    {
                        efdata = objMedicalData.OrderByDescending(m => m.CreationDate).FirstOrDefault().EjectionFractionPercent;
                    }
                }
                pathhome.ICDColor = "yellowDiv";
                var hasICD = false;
                pathhome.EjecFraction = efdata.ToString();
                if (efdata < 40 && pathhome.HasICD && (objMedicalData != null && objMedicalData.Count > 0))
                {
                    if (Top3Rows != null)
                    {
                        if (Top3Rows.Any(x => x.IsActive && string.Compare(x.MedicalHistoryTypeName.ToLower(), "presence of an icd") == 0))
                        {
                            pathhome.ICDColor = "greenDiv";
                            hasICD = true;
                        }
                    }

                    var opt = GetPatientICDDeviceOption(medicationQO.PatientID);
                    if (opt != null)
                    {
                        if (opt.ICDDeviceOptionID == (int)ICDDeviceOption.HasICD && hasICD)
                        {
                            pathhome.ICDColor = "greenDiv";
                        }
                    }
                }
                else if (efdata < 40 && !pathhome.HasICD && (objMedicalData != null && objMedicalData.Count > 0))
                {
                    if (!string.IsNullOrEmpty(QueAns.IsData))
                    {
                        if (!QueAns.IsTherapy)
                        {
                            pathhome.ICDColor = "grayDiv";
                        }
                        else if (!QueAns.IsCoronaryRev)
                        {
                            pathhome.ICDColor = "yellowDiv";
                        }
                        else if (QueAns.IsCoronaryRev)
                        {
                            pathhome.ICDColor = "redDiv";
                        }
                        else
                        {
                            pathhome.ICDColor = "flashRedDiv";
                        }
                    }
                    else
                    {
                        pathhome.ICDColor = "flashRedDiv";
                    }

                }
                else
                {

                    pathhome.ICDColor = "grayDiv";

                }

                res.Record = pathhome;
                return res;
            }
            catch (Exception ex)
            {
                MedicationResult res = new MedicationResult();
                res.Status = "0";
                res.Message = "Please contact administrator.";
                res.Record = null;
                res.Info = null;
                return res;
            }
        }

        public Result AddMedicalDataRest(
            string PatientID,
            string ID,
            string ACCHeartFailureStageID,
            string NYHAClassID,
            decimal EjectionFractionPercent, string txtEjectionFractionDate,
            string ICDDeviceOptionID,
            string ICDDeviceTypeID, string UserID, string orgID)
        {

            Result res = new Result();
            var patientMedicalData = new PatientMedicalData();
            patientMedicalData.PatientID = Guid.Parse(PatientID);
            patientMedicalData.ID = string.IsNullOrEmpty(ID) == true ? Guid.Empty : Guid.Parse(ID);
            int ACCHeartFailureStageID1 = string.IsNullOrEmpty(ACCHeartFailureStageID) == true ? Int32.MinValue : Convert.ToInt32(ACCHeartFailureStageID);
            int NYHAClassID1 = string.IsNullOrEmpty(NYHAClassID) == true ? Int32.MinValue : Convert.ToInt32(NYHAClassID);
            patientMedicalData.ACCHeartFailureStageID = (ACCHeartFailureClassificationType)ACCHeartFailureStageID1;
            patientMedicalData.NYHAClassID = (NYHAClassificationType)NYHAClassID1;
            patientMedicalData.EjectionFractionPercent = EjectionFractionPercent;
            if (txtEjectionFractionDate != null)
            {
                if (txtEjectionFractionDate.Length > 3)
                {
                    patientMedicalData.EjectionFractionDate = Convert.ToDateTime(txtEjectionFractionDate.ToString());
                }
                else
                {
                    patientMedicalData.EjectionFractionDate = DateTime.MinValue;
                }
            }
            else
            {
                patientMedicalData.EjectionFractionDate = DateTime.MinValue;
            }
            string result = "success";
            List<string> msg11 = new List<string>();

            try
            {

                patientMedicalData.CreatedBy = Guid.Parse(UserID);
                patientMedicalData.LastUpdatedBy = Guid.Parse(UserID);
                if (patientMedicalData.ACCHeartFailureStageID != ACCHeartFailureClassificationType.none &&
                    patientMedicalData.NYHAClassID != NYHAClassificationType.None)
                {
                    List<string> msg = new List<string>();
                    msg.Add("ssds");

                    patientMedicalData = SavePatientMedicalData(patientMedicalData);
                }


                int icdDeviceTypeID;
                if (!int.TryParse(ICDDeviceTypeID, out icdDeviceTypeID))
                {
                    icdDeviceTypeID = Int32.MinValue;
                }
                if (icdDeviceTypeID == 0)
                {
                    icdDeviceTypeID = Int32.MinValue;
                }
                int icdDeviceOptionID;
                if (!int.TryParse(ICDDeviceOptionID, out icdDeviceOptionID))
                {
                    icdDeviceOptionID = Int32.MinValue;
                }
                if (icdDeviceOptionID == 0)
                {
                    icdDeviceOptionID = Int32.MinValue;
                }

                if (icdDeviceOptionID != Int32.MinValue)
                {
                    SavePatientICDDeviceOption(new PatientICDDeviceOption()
                    {
                        PatientID = Guid.Parse(PatientID),
                        CreatedBy = Guid.Parse(UserID),
                        ICDDeviceTypeID = icdDeviceTypeID,
                        ICDDeviceOptionID = icdDeviceOptionID,
                    });

                    if (icdDeviceOptionID == (int)ICDDeviceOption.HasICD)
                    {
                        var types = GetDLLookUp().GetLookUpValues(new MasterLookUpQO() { OrganizationID = Guid.Parse(orgID), TableType = LuTableType.LuMedicalHistoryType });
                        var history = GetPatientMedicalHistory(new PatientMedicalHistoryQO() { PatientID = Guid.Parse(PatientID) });
                        var hasICD = history.Any(x => x.IsActive && string.Compare(x.MedicalHistoryTypeName.ToLower(), "presence of an icd") == 0);

                        var icdType = types.FirstOrDefault(x => string.Compare(x.Name.ToLower(), "presence of an icd") == 0);
                        if (!hasICD && icdType != null)
                        {
                            SavePatientMedicalHistory(new PatientMedicalHistory()
                            {
                                IsActive = true,
                                MedicalHistoryTypeID = icdType.ID,
                                Comments = "",
                                CreatedBy = Guid.Parse(UserID),
                                ICDDeviceTypeID = icdDeviceTypeID,
                                PatientID = Guid.Parse(PatientID),
                            });
                        }
                    }
                }
            }
            catch
            {
                //Log error
                result = "failure";

            }
            if (result == "success")
            {
                res.Status = "1";
                res.Message = "Success";

            }
            else
            {
                res.Status = "0";
                res.Message = "Failure";
            }
            return res;
        }

        public PatientHistoryResult GetPatientMedicalHistoryRest(PatientMedicalHistoryQO medHistoryQO)
        {
            try
            {
                ObservableCollection<PatientMedicalHistory> medHistory =
                    GetDLPatient().GetPatientMedicalHistory(medHistoryQO);
                PatientHistoryResult res = new PatientHistoryResult();
                res.Status = "1";
                res.Message = "Success";
                res.Record = medHistory.Where(m => m.MedicalHistoryTypeName != "").Select(x => new PatientHistoryRest { ICDDeviceName = string.IsNullOrEmpty(x.ICDDeviceTypeName) ? "" : x.ICDDeviceTypeName, ID = x.ID.ToString(), MedTypeID = x.MedicalHistoryTypeID.ToString(), ICDDeviceID = x.ICDDeviceTypeID.ToString(), Item = x.MedicalHistoryTypeName, CreateDate = x.CreationDate.ToString("MM/dd/yyyy"), Comments = string.IsNullOrEmpty(x.Comments) ? "" : x.Comments }).ToList();
                var patientdet = GetPatientDemographics(new PatientQO() { ID = medHistoryQO.PatientID });
                PatientHeaderInfoRest objP = new PatientHeaderInfoRest();
                objP.City = (patientdet.Address.City == null) ? "" : patientdet.Address.City;
                objP.Address = (patientdet.Address.Street1 == null) ? "" : patientdet.Address.Street1;
                objP.Zip = (patientdet.Address.Zip.ToString() == null) ? "" : patientdet.Address.Zip.ToString();
                string statename = ((StateType)patientdet.Address.StateID).ToString();
                objP.State = (statename == null) ? "" : statename;
                objP.Age = patientdet.PatientAge.ToString();
                objP.GenderID = patientdet.GenderID.ToString();
                objP.DOB = patientdet.DOB.ToString("MM/dd/yyyy").Replace("-", "/");
                objP.CellPhone = (patientdet.CellPhoneNumber == null) ? "" : patientdet.CellPhoneNumber;
                objP.WorkPhoneNumber = (patientdet.WorkPhoneNumber == null) ? "" : patientdet.WorkPhoneNumber;
                objP.PharmcyPhone = (patientdet.PharmacyPhone == null) ? "" : patientdet.PharmacyPhone;
                string lastsubdate = "";
                PatientVitalSignsQO qoObjvital = new PatientVitalSignsQO() { PatientID = medHistoryQO.PatientID };
                ObservableCollection<PatientVitalSign> objvitalSigns = new ObservableCollection<PatientVitalSign>();
                objvitalSigns = GetPatientVitalSigns(qoObjvital, false);
                ObservableCollection<PatientMedicalData> objMedicalData = new ObservableCollection<PatientMedicalData>();
                PatientMedicalDataQO qoObj = new PatientMedicalDataQO() { PatientID = medHistoryQO.PatientID };
                objMedicalData = GetPatientMedicalData(qoObj);
                if (objvitalSigns.Count > 0)
                {
                    // CurrentVital = objvitalSigns.First();
                    //---- 27 Aug 2019 -- Patient Dashboard > Blue Boxes of Vital -- do not show vital which are added from CCM Review Page.. so check applied here
                    lastsubdate = objvitalSigns.First(x => x.IsCCM == false).CreationDate.ToString("MM/dd/yyyy HH:mm:ss ttt");
                }
                objP.LastSubmittedVital = lastsubdate.Replace("-", "/");
                if (objMedicalData.Count > 0)
                {
                    objP.HFClass = "Stage: " + objMedicalData[0].ACCHeartFailureStageID.ToString() + ", NYHA: " +objMedicalData[0].NYHAClassID.ToString() + ", E.F.: " + Math.Round(objMedicalData[0].EjectionFractionPercent) + "%";
                }
                objP.MedicationAsof = (objP.MedicationAsof == null) ? "" : objP.MedicationAsof;
                res.Info = objP;
                return res;
            }
            catch (Exception ex)
            {
                PatientHistoryResult res = new PatientHistoryResult();
                res.Status = "0";
                res.Message = "Fail";
                res.Record = null;
                res.Info = null;
                return res;
            }
        }
        string GetColor(MedicationScale scaleID)
        {
            string ret = "";

            if (scaleID == MedicationScale.Red)
            {
                ret = "redDiv";
            }
            if (scaleID == MedicationScale.Blue)
            {
                ret = "blueDiv";
            }
            if (scaleID == MedicationScale.Green)
            {
                ret = "greenDiv";
            }
            if (scaleID == MedicationScale.Yellow)
            {
                ret = "yellowDiv";
            }
            if (scaleID == MedicationScale.Orange)
            {
                ret = "orangeDiv";
            }
            return ret;
        }

        public VitalResults GetPatientVitalRest(PatientVitalSignsQO vitalsQO)
        {
            VitalResults res = new VitalResults();

            try
            {
                res.Record = GetDLPatient().GetPatientVitalRest(vitalsQO);
                res.Status = "1";
                res.Message = "Success";

                return res;
            }
            catch (Exception ex)
            {
                res.Status = "1";
                res.Message = "Please contact administrator.";
                res.Record = null;
                return res;

            }

        }

        public List<string> NextByDayOfWeek(DateTime startDate, int daycount)
        {
            int actualDay = 7;
            actualDay = daycount - actualDay;
            startDate = startDate.AddDays(actualDay+1);
            DateTime endDate = startDate.AddDays(6);
            List<string> list = new List<string>();
            for (DateTime runDate = startDate; runDate <= endDate; runDate = runDate.AddDays(1))
            {
                // Add day name in list
                list.Add(runDate.DayOfWeek.ToString().Substring(0, 3));
            }
            DayofMOnths(startDate, daycount);
            return list;
        }


        public List<string> DayofMOnths(DateTime startDate, int daycount)
        {
            startDate = DateTime.Now.AddDays(-daycount);
           // int actualDay = 7;
            //actualDay = daycount - actualDay;
            //startDate = startDate.AddDays(actualDay);
            DateTime endDate = DateTime.Now;// startDate.AddDays(daycount);
            List<string> list = new List<string>();
            int incr = 1;
            //if (daycount > 7 && daycount <= 30)
            //{
            //    incr = 2;
            //}
            //else if (daycount > 30 && daycount <= 60)
            //{
            //    incr = 4;
            //}
            //else if (daycount > 60 && daycount <= 90)
            //{
            //    incr = 5;
            //}
            //else
            //if (daycount > 90)
            //{
            //    incr = 3;
            //}

            for (DateTime runDate = startDate; runDate <= endDate; runDate = runDate.AddDays(incr))
            {
                // Add day name in list
               // list.Add(runDate.ToString());
               if (daycount <= 7)
                {
                    list.Add(runDate.DayOfWeek.ToString().Substring(0, 3));
                }
                else { list.Add(runDate.ToString()); }
            }

            return list;
        }
        public VitalResults GetPatientVitalForGraphRest(PatientVitalSignsQO vitalsQO, int days)
        {
            VitalResults res = new VitalResults();

            try
            {
                var recs = GetDLPatient().GetPatientVitalSignsList(vitalsQO, days);
                List<PatientVitalLastest> list = new List<PatientVitalLastest>();

                if (recs != null)
                {
                    string _o2 = "0";
                    string _syst = "0";
                    string _dist = "0";
                    string _weight = "0";
                    string _pulse = "0";
                    int _act = 0;
                    int _qua = 0;
                    if (days > 7)
                    {
                        var DayNames = DayofMOnths(Convert.ToDateTime(recs[recs.Count-1].CreationDate), days);
                        foreach (var dayname in DayNames)
                        {
                            PatientVitalLastest obj = new PatientVitalLastest();
                            var patVtalDET = recs.Where(x => Convert.ToDateTime(x.CreationDate).Date == Convert.ToDateTime(dayname).Date).OrderByDescending(xd => xd.CreationDate).FirstOrDefault();
                            if (patVtalDET != null)
                            {
                                obj.DayName = patVtalDET.DayNam;
                                if (patVtalDET.SystolicPressure != "0")
                                {
                                    obj.SystolicPressure = patVtalDET.SystolicPressure;
                                    _syst = patVtalDET.SystolicPressure;
                                }
                                else {
                                    obj.SystolicPressure = _syst;
                                }
                                if (patVtalDET.DiastolicPressure != "0")
                                {
                                    obj.DiastolicPressure = patVtalDET.DiastolicPressure;
                                    _dist = patVtalDET.DiastolicPressure;
                                }
                                else
                                {
                                    obj.DiastolicPressure = _dist;
                                }
                                if (patVtalDET.O2Sat != "0")
                                {
                                    obj.O2Sat = patVtalDET.O2Sat;
                                    _o2 = patVtalDET.O2Sat;
                                }
                                else
                                {
                                    obj.O2Sat = _o2;
                                }
                                if (patVtalDET.Pulse != "0")
                                {
                                    obj.Pulse = patVtalDET.Pulse;
                                    _pulse = patVtalDET.Pulse;
                                }
                                else
                                {
                                    obj.Pulse = _pulse;
                                }
                                if (patVtalDET.Weight != "0")
                                {
                                    obj.Weight = patVtalDET.Weight;
                                    _weight = patVtalDET.Weight;
                                }
                                else
                                {
                                    obj.Weight = _weight;
                                }

                                if (patVtalDET.ActivityID != 0)
                                {
                                    obj.ActivityID = Convert.ToString(patVtalDET.ActivityID);
                                    _act = patVtalDET.ActivityID;
                                }
                                else
                                {
                                    obj.ActivityID = Convert.ToString(_act);
                                }

                                if (patVtalDET.QualityOfLifeID != 0)
                                {
                                    obj.QualityOfLifeID = Convert.ToString(patVtalDET.QualityOfLifeID);
                                    _qua = patVtalDET.QualityOfLifeID;
                                }
                                else
                                {
                                    obj.QualityOfLifeID = Convert.ToString(_qua);
                                }
                                
                              
                                obj.CreationDate = patVtalDET.CreationDate.ToString();

                            }
                            else
                            {
                                obj.DayName = dayname;
                                obj.SystolicPressure = _syst;
                                obj.DiastolicPressure = _dist;
                                obj.O2Sat = _o2;
                                obj.Pulse = _pulse;
                                obj.Weight = _weight;
                                obj.ActivityID = Convert.ToString(_act);
                                obj.QualityOfLifeID = Convert.ToString(_qua);
                                obj.CreationDate = dayname.ToString();
                            }
                            list.Add(obj);

                        }
                    }
                    else
                    {
                        var DayNames = NextByDayOfWeek(Convert.ToDateTime(recs[recs.Count - 1].CreationDate), recs[recs.Count - 1].DayCount);
                        foreach (var dayname in DayNames)
                        {
                            PatientVitalLastest obj = new PatientVitalLastest();
                            var patVtalDET = recs.Where(x => x.dayNam == dayname).OrderByDescending(xd => xd.CreationDate).FirstOrDefault();
                            if (patVtalDET != null)
                            {
                                obj.DayName = patVtalDET.DayNam;
                                //obj.SystolicPressure = patVtalDET.SystolicPressure;
                                //obj.DiastolicPressure = patVtalDET.DiastolicPressure;
                                //obj.O2Sat = patVtalDET.O2Sat;
                                //obj.Pulse = patVtalDET.Pulse;
                                //obj.Weight = patVtalDET.Weight;
                                if (patVtalDET.SystolicPressure != "0")
                                {
                                    obj.SystolicPressure = patVtalDET.SystolicPressure;
                                    _syst = patVtalDET.SystolicPressure;
                                }
                                else
                                {
                                    obj.SystolicPressure = _syst;
                                }
                                if (patVtalDET.DiastolicPressure != "0")
                                {
                                    obj.DiastolicPressure = patVtalDET.DiastolicPressure;
                                    _dist = patVtalDET.DiastolicPressure;
                                }
                                else
                                {
                                    obj.DiastolicPressure = _dist;
                                }
                                if (patVtalDET.O2Sat != "0")
                                {
                                    obj.O2Sat = patVtalDET.O2Sat;
                                    _o2 = patVtalDET.O2Sat;
                                }
                                else
                                {
                                    obj.O2Sat = _o2;
                                }
                                if (patVtalDET.Pulse != "0")
                                {
                                    obj.Pulse = patVtalDET.Pulse;
                                    _pulse = patVtalDET.Pulse;
                                }
                                else
                                {
                                    obj.Pulse = _pulse;
                                }
                                if (patVtalDET.Weight != "0")
                                {
                                    obj.Weight = patVtalDET.Weight;
                                    _weight = patVtalDET.Weight;
                                }
                                else
                                {
                                    obj.Weight = _weight;
                                }
                                if (patVtalDET.ActivityID != 0)
                                {
                                    obj.ActivityID = Convert.ToString(patVtalDET.ActivityID);
                                    _act = patVtalDET.ActivityID;
                                }
                                else
                                {
                                    obj.ActivityID = Convert.ToString(_act);
                                }

                                if (patVtalDET.QualityOfLifeID != 0)
                                {
                                    obj.QualityOfLifeID = Convert.ToString(patVtalDET.QualityOfLifeID);
                                    _qua = patVtalDET.QualityOfLifeID;
                                }
                                else
                                {
                                    obj.QualityOfLifeID = Convert.ToString(_qua);
                                }
                                //obj.ActivityID = Convert.ToString(patVtalDET.ActivityID);
                                //obj.QualityOfLifeID = Convert.ToString(patVtalDET.QualityOfLifeID);
                            }
                            else
                            {
                                obj.DayName = dayname;
                                //obj.SystolicPressure = "0";
                                //obj.DiastolicPressure = "0";
                                //obj.O2Sat = "0";
                                //obj.Pulse = "0";
                                //obj.Weight = "0";
                                obj.SystolicPressure = _syst;
                                obj.DiastolicPressure = _dist;
                                obj.O2Sat = _o2;
                                obj.Pulse = _pulse;
                                obj.Weight = _weight;
                                obj.ActivityID = Convert.ToString(_act);
                                obj.QualityOfLifeID = Convert.ToString(_qua);
                            }
                            list.Add(obj);

                        }
                    }
                }
                res.Status = "1";
                res.Message = "Success";
                res.Record = list;
                return res;
            }
            catch (Exception ex)
            {
                res.Status = "1";
                res.Message = "Please contact administrator.";
                res.Record = null;
                return res;

            }

        }


        public VitalInfoDropdownsResult GetPatientVitalSignsRest(PatientVitalSignsQO vitalsQO)
        {
            VitalInfoDropdownsResult res = new VitalInfoDropdownsResult();
            try
            {
                ObservableCollection<LookUpItem> qolList = this.GetDLLookUp().GetLookUpValues(new MasterLookUpQO { TableType = LuTableType.LuPatientQOLScore });
                res.Quality = qolList.OrderBy(q => q.ID).Select(x => new DropdownItems { ID = x.ID, Name = x.Name }).ToList();
                ObservableCollection<LookUpItem> activityList = this.GetDLLookUp().GetLookUpValues(new MasterLookUpQO { TableType = LuTableType.LuPatientActivityScore });
                res.Activity = activityList.OrderBy(q => q.ID).Select(x => new DropdownItems { ID = x.ID, Name = x.Name }).ToList();
                res.Status = "1";
                res.Message = "Success";
                return res;
            }
            catch (Exception ex)
            {
                res.Status = "1";
                res.Message = "Please contact administrator.";
                res.Quality = null;
                res.Activity = null;
                return res;

            }
        }

        public PatientMedHistoryResult GetPatientMedHistoryRest(string orgid, string patientid)
        {
            PatientMedHistoryResult res = new PatientMedHistoryResult();
            try
            {
                ObservableCollection<LookUpItem> Medcondition = this.GetDLLookUp().GetLookUpValues(new MasterLookUpQO { TableType = LuTableType.LuMedicalHistoryType, OrganizationID = Guid.Parse(orgid) });
                res.Medcondition = Medcondition.OrderBy(q => q.ID).Select(x => new DropdownItems { ID = x.ID, Name = x.Name }).ToList();
                ObservableCollection<LookUpItem> Icds = this.GetDLLookUp().GetLookUpValues(new MasterLookUpQO { TableType = LuTableType.LuICDDeviceType, OrganizationID = Guid.Parse(orgid) });
                res.Icds = Icds.OrderBy(q => q.ID).Select(x => new DropdownItems { ID = x.ID, Name = x.Name }).ToList();
                var patientdet = GetPatientDemographics(new PatientQO() { ID = Guid.Parse(patientid) });
                PatientHeaderInfoRest objP = new PatientHeaderInfoRest();
                objP.City = (patientdet.Address.City == null) ? "" : patientdet.Address.City;
                objP.Address = (patientdet.Address.Street1 == null) ? "" : patientdet.Address.Street1;
                objP.Zip = (patientdet.Address.Zip.ToString() == null) ? "" : patientdet.Address.Zip.ToString();
                string statename = ((StateType)patientdet.Address.StateID).ToString();
                objP.State = (statename == null) ? "" : statename;
                objP.Age = patientdet.PatientAge.ToString();
                objP.GenderID = patientdet.GenderID.ToString();
                objP.DOB = patientdet.DOB.ToString("MM/dd/yyyy").Replace("-", "/");
                objP.CellPhone = (patientdet.CellPhoneNumber == null) ? "" : patientdet.CellPhoneNumber;
                objP.WorkPhoneNumber = (patientdet.WorkPhoneNumber == null) ? "" : patientdet.WorkPhoneNumber;
                objP.PharmcyPhone = (patientdet.PharmacyPhone == null) ? "" : patientdet.PharmacyPhone;
                string lastsubdate = "";
                PatientVitalSignsQO qoObjvital = new PatientVitalSignsQO() { PatientID = Guid.Parse(patientid) };
                ObservableCollection<PatientVitalSign> objvitalSigns = new ObservableCollection<PatientVitalSign>();
                objvitalSigns = GetPatientVitalSigns(qoObjvital, false);
                ObservableCollection<PatientMedicalData> objMedicalData = new ObservableCollection<PatientMedicalData>();
                PatientMedicalDataQO qoObj = new PatientMedicalDataQO() { PatientID = Guid.Parse(patientid) };
                objMedicalData = GetPatientMedicalData(qoObj);
                if (objvitalSigns.Count > 0)
                {
                    // CurrentVital = objvitalSigns.First();
                    //---- 27 Aug 2019 -- Patient Dashboard > Blue Boxes of Vital -- do not show vital which are added from CCM Review Page.. so check applied here
                    lastsubdate = objvitalSigns.First(x => x.IsCCM == false).CreationDate.ToString("MM/dd/yyyy HH:mm:ss ttt");
                }
                objP.LastSubmittedVital = lastsubdate.Replace("-", "/");
                if (objMedicalData.Count > 0)
                {
                    objP.HFClass = "Stage: " + objMedicalData[0].ACCHeartFailureStageID.ToString() + ", NYHA: " + objMedicalData[0].NYHAClassID.ToString() + ", E.F.: " + Math.Round(objMedicalData[0].EjectionFractionPercent) + "%";
                }
                objP.MedicationAsof = (objP.MedicationAsof == null) ? "" : objP.MedicationAsof;
                res.Info = objP;
                res.Status = "1";
                res.Message = "Success";
                return res;
            }
            catch (Exception ex)
            {
                res.Status = "1";
                res.Message = ex.Message;
                res.Medcondition = null;
                res.Icds = null;
                return res;

            }
        }
        public PatientInfoResult PatientBasicInfoRest(PatientQO patient)
        {
            PatientInfoResult res = new PatientInfoResult();
            try
            {
                var patientdet = GetPatientDemographics(new PatientQO() { ID = patient.ID });
                PatientHeaderInfoRest objP = new PatientHeaderInfoRest();
                objP.City = (patientdet.Address.City == null) ? "" : patientdet.Address.City;
                objP.Address = (patientdet.Address.Street1 == null) ? "" : patientdet.Address.Street1;
                objP.Address2 = (patientdet.Address.Street2 == null) ? "" : patientdet.Address.Street2;
                objP.Zip = (patientdet.Address.Zip.ToString() == null) ? "" : patientdet.Address.Zip.ToString();
                string statename = ((StateType)patientdet.Address.StateID).ToString();
                objP.State = (statename == null) ? "" : statename;
                objP.Age = patientdet.PatientAge.ToString();
                objP.GenderID = patientdet.GenderID.ToString();
                objP.DOB = patientdet.DOB.ToString("MM/dd/yyyy").Replace("-", "/");
                objP.CellPhone = (patientdet.CellPhoneNumber == null) ? "" : patientdet.CellPhoneNumber;
                objP.WorkPhoneNumber = (patientdet.WorkPhoneNumber == null) ? "" : patientdet.WorkPhoneNumber;
                objP.PharmcyPhone = (patientdet.PharmacyPhone == null) ? "N/A" : patientdet.PharmacyPhone;

                objP.HomePhone = (patientdet.PhoneNumber == null) ? "" : patientdet.PhoneNumber;
                //  objP.Address = patientdet.Address.Street1;
                objP.City = patientdet.Address.City;
                objP.State = ((StateType)patientdet.Address.StateID).ToString();
                objP.Zip = patientdet.Address.Zip.ToString();
                string lastsubdate = "";
                PatientVitalSignsQO qoObjvital = new PatientVitalSignsQO() { PatientID = patient.ID };
                ObservableCollection<PatientVitalSign> objvitalSigns = new ObservableCollection<PatientVitalSign>();
                objvitalSigns = GetPatientVitalSigns(qoObjvital, false);
                ObservableCollection<PatientMedicalData> objMedicalData = new ObservableCollection<PatientMedicalData>();
                PatientMedicalDataQO qoObj = new PatientMedicalDataQO() { PatientID = patient.ID };
                objMedicalData = GetPatientMedicalData(qoObj);
                if (objvitalSigns.Count > 0)
                {
                    // CurrentVital = objvitalSigns.First();
                    //---- 27 Aug 2019 -- Patient Dashboard > Blue Boxes of Vital -- do not show vital which are added from CCM Review Page.. so check applied here
                    lastsubdate = objvitalSigns.First(x => x.IsCCM == false).CreationDate.ToString("MM/dd/yyyy HH:mm:ss ttt");
                }
                objP.LastSubmittedVital = lastsubdate.Replace("-", "/");
                if (objMedicalData.Count > 0)
                {
                    objP.HFClass = "Stage: " + objMedicalData[0].ACCHeartFailureStageID.ToString() + ", NYHA: " + objMedicalData[0].NYHAClassID.ToString() + ", E.F.: " + Math.Round(objMedicalData[0].EjectionFractionPercent) + "%";
                }
                objP.MedicationAsof = (objP.MedicationAsof == null) ? "" : objP.MedicationAsof;
                res.Info = objP;

                var basicdata = GetDLPatient().GetPatientInfoRest(patient.ID.ToString());
                res.Contact = basicdata.Contact;
                res.HFD = basicdata.HFD;
                res.Status = "1";
                res.Message = "Success";
                return res;
            }
            catch (Exception ex)
            {
                res.Status = "1";
                res.Message = ex.Message;
                res.Contact = null;
                res.HFD = null;
                return res;

            }
        }

        public Result ICDQuestionsRest(string PatientID, Guid UserID, string type, bool status)
        {
            Result res = new Result();
            try
            {
                this.GetDLPatient().SetICDQueAns(PatientID, UserID, type, status);
                res.Status = "1";
                res.Message = "success";
            }
            catch (Exception ex)
            {
                res.Status = "0";
                res.Message = ex.Message;


            }
            return res;
        }

        public Result AddMedicalHistoryRest(string patientid, string id, int MedicalHistoryTypeID, int ICDDeviceTypeID, string comments, string userid, bool IsActive)
        {
            Result res = new Result();
            var ptMedicalHistory = new PatientMedicalHistory();
            ptMedicalHistory.PatientID = Guid.Parse(patientid);
            if (!string.IsNullOrEmpty(id))
            {
                if (id != "0")
                {
                    ptMedicalHistory.ID = Guid.Parse(id);
                }
            }
            ptMedicalHistory.MedicalHistoryTypeID = MedicalHistoryTypeID; //(OtherMedicalHistoryType == "") ? (MedicalHistoryTypeID) : -1;
            ptMedicalHistory.Comments = comments;
            ptMedicalHistory.ICDDeviceTypeID = ICDDeviceTypeID;


            try
            {

                ptMedicalHistory.CreatedBy = Guid.Parse(userid);
                ptMedicalHistory.LastUpdatedBy = Guid.Parse(userid);
                ptMedicalHistory.IsActive = true;
                ptMedicalHistory = SavePatientMedicalHistory(ptMedicalHistory);

                if (ICDDeviceTypeID != Int32.MinValue && ICDDeviceTypeID > 0)
                {
                    var history = GetPatientMedicalHistory(new PatientMedicalHistoryQO() { PatientID = Guid.Parse(patientid) });
                    var isICD = history.Any(x => x.MedicalHistoryTypeID == ptMedicalHistory.MedicalHistoryTypeID &&
                        x.IsActive && string.Compare(x.MedicalHistoryTypeName.ToLower(), "presence of an icd") == 0);

                    if (isICD)
                    {
                        SavePatientICDDeviceOption(new PatientICDDeviceOption()
                        {
                            PatientID = Guid.Parse(patientid),
                            CreatedBy = Guid.Parse(userid),
                            ICDDeviceTypeID = ICDDeviceTypeID,
                            ICDDeviceOptionID = (int)ICDDeviceOption.HasICD,
                        });
                    }
                }
                if (ptMedicalHistory.ID == Guid.Parse("00000000-0000-0000-0000-000000000000") || ptMedicalHistory.ID == Guid.Empty)
                {
                    res.Status = "1";
                    res.Message = "Past medical history added successfully.";
                    return res;
                }
                else
                {
                    res.Status = "1";
                    res.Message = "Past medical history updated successfully.";
                    return res;
                }
            }
            catch (Exception ex)
            {
                res.Status = "0";
                res.Message = ex.Message;

                return res;
            }

        }

        public PatientVitalwithInfoResult PatientInfoWithVitalRest(PatientQO patient)
        {
            PatientVitalwithInfoResult res = new PatientVitalwithInfoResult();
            try
            {
                //PatientVitalsWithInfo result = this.GetDLPatient().GetPatientVitalWithInfo(qoObj);
                res.Record = this.GetDLPatient().GetPatientVitalWithInfo(patient);

                res.Status = "1";
                res.Message = "Success";
                return res;
            }
            catch (Exception ex)
            {
                res.Status = "1";
                res.Message = ex.Message;

                res.Record = null;
                return res;

            }
        }

        /*! 
        * \brief    it will create goal for patient weight, pulse, BP etc 
        * \details  it will create goal for patient weight, pulse, BP etc 
        * \author    Kate 
        * \date     4 june 2019
        * \version 1.0    
        */
        private string BuildGoalString(int Min, int Max)
        {
            string BuildGoalString = string.Empty;

            if (Min != Int32.MinValue & Max != Int32.MinValue)
                BuildGoalString = "(" + Min.ToString() + " - " + Max.ToString() + ")";

            if (Min != Int32.MinValue & Max == Int32.MinValue)
                BuildGoalString = "( > " + Min.ToString() + ")";

            if (Min == Int32.MinValue & Max != Int32.MinValue)
                BuildGoalString = "( < " + Max.ToString() + ")";

            if (Min == Int32.MinValue & Max == Int32.MinValue)
                BuildGoalString = "(N/A)";

            return BuildGoalString;
        }

        public PatientVitalResults PatientVitalDataRest(PatientQO patient)
        {
            PatientVitalResults res = new PatientVitalResults();
            try
            {
                ObservableCollection<PatientVitalSign> objvitalSigns = new ObservableCollection<PatientVitalSign>();
                PatientVitalSignsQO qoObj = new PatientVitalSignsQO();
                qoObj.PatientID = patient.ID;
                objvitalSigns = GetPatientVitalSigns(qoObj, false);

                if (objvitalSigns.Count > 0)
                {
                    // CurrentVital = objvitalSigns.First();
                    //---- 27 Aug 2019 -- Patient Dashboard > Blue Boxes of Vital -- do not show vital which are added from CCM Review Page.. so check applied here
                    PatientVitalSign vitalres = objvitalSigns.First(x => x.IsCCM == false);
                    PatientVitalLastest obj = new PatientVitalLastest();
                    obj.Pulse = (vitalres.Pulse == null) ? "" : vitalres.Pulse;
                    obj.DiastolicPressure = (vitalres.DiastolicPressure == null) ? "" : vitalres.DiastolicPressure;
                    obj.SystolicPressure = (vitalres.SystolicPressure == null) ? "" : vitalres.SystolicPressure;
                    obj.Weight = (vitalres.Weight == null) ? "" : vitalres.Weight;
                    obj.O2Sat = (vitalres.O2Sat == null) ? "" : vitalres.O2Sat; ;
                    obj.QualityOfLifeID = (vitalres.QualityOfLifeID.ToString() == null) ? "" : vitalres.QualityOfLifeID.ToString();
                    obj.ActivityID = (vitalres.ActivityID.ToString() == null) ? "" : vitalres.ActivityID.ToString();
                    obj.QualityOfLifeText = (vitalres.QualityOfLifeText == null) ? "" : vitalres.QualityOfLifeText;
                    obj.ActivityText = (vitalres.ActivityText == null) ? "" : vitalres.ActivityText;
                    res.Record = obj;
                }
                var objpatientalertcount = GetPatientAlertCount(patient.ID);
                if (objpatientalertcount.Count == 0)
                {
                    res.PulseCounter = 0;
                    res.PulseIsSent = 0;
                    res.WeightCounter = 0;
                    res.WeightIsSent = 0;
                    res.SatsCounter = 0;
                    res.SatsIsSent = 0;
                    res.SystolicCounter = 0;
                    res.SystolicIsSent = 0;
                    res.DiastolicCounter = 0;
                    res.DiastolicIsSent = 0;

                }
                else
                {

                    res.PulseCounter = objpatientalertcount.FirstOrDefault(m => m.CID == 2).Count;
                    res.PulseIsSent = objpatientalertcount.FirstOrDefault(m => m.CID == 2).IsSent;
                    res.WeightCounter = objpatientalertcount.FirstOrDefault(m => m.CID == 6).Count;
                    res.WeightIsSent = objpatientalertcount.FirstOrDefault(m => m.CID == 6).IsSent;
                    res.SatsCounter = objpatientalertcount.FirstOrDefault(m => m.CID == 5).Count;
                    res.SatsIsSent = objpatientalertcount.FirstOrDefault(m => m.CID == 5).IsSent;
                    res.SystolicCounter = objpatientalertcount.FirstOrDefault(m => m.CID == 3).Count;
                    res.SystolicIsSent = objpatientalertcount.FirstOrDefault(m => m.CID == 3).IsSent;
                    res.DiastolicCounter = objpatientalertcount.FirstOrDefault(m => m.CID == 4).Count;
                    res.DiastolicIsSent = objpatientalertcount.FirstOrDefault(m => m.CID == 4).IsSent;
                }
                PatientClass patientClass = GetPatientGoals(new PersonQO() { ID = patient.ID });

                if (patientClass.Goals != null && patientClass.Goals.Count > 0)
                {
                    VitalGoals pathome = new VitalGoals();

                    foreach (PatientClassGoal goal in patientClass.Goals)
                    {
                        switch (goal.GoalTypeID)
                        {
                            case MyPulsario.Common.Enums.PatientClassGoalType.HeartRate:
                                pathome.PulseGoal = BuildGoalString(goal.MinValue, goal.MaxValue);
                                break;
                            case MyPulsario.Common.Enums.PatientClassGoalType.SystolicBP:
                                pathome.SystolicGoal = BuildGoalString(goal.MinValue, goal.MaxValue);
                                break;
                            case MyPulsario.Common.Enums.PatientClassGoalType.DiastolicBP:
                                pathome.DiastolicGoal = BuildGoalString(goal.MinValue, goal.MaxValue);
                                break;
                            case MyPulsario.Common.Enums.PatientClassGoalType.O2Sat:
                                pathome.SatsGoal = BuildGoalString(goal.MinValue, goal.MaxValue);
                                break;
                            case MyPulsario.Common.Enums.PatientClassGoalType.Weight:
                                pathome.WeightGoal = BuildGoalString(goal.MinValue, goal.MaxValue);
                                break;

                        }
                    }
                    res.Goals = pathome;
                }
                var patientdet = GetPatientDemographics(new PatientQO() { ID = patient.ID });
                ObservableCollection<PatientMedicalData> objMedicalData = new ObservableCollection<PatientMedicalData>();
                PatientMedicalDataQO qoObj1 = new PatientMedicalDataQO() { PatientID = patient.ID };
                objMedicalData = GetPatientMedicalData(qoObj1);
                PatientHeaderInfoRest objP = new PatientHeaderInfoRest();
                objP.City = (patientdet.Address.City == null) ? "" : patientdet.Address.City;
                objP.Address = (patientdet.Address.Street1 == null) ? "" : patientdet.Address.Street1;
                objP.Address2 = (patientdet.Address.Street2 == null) ? "" : patientdet.Address.Street2;
                objP.Zip = (patientdet.Address.Zip.ToString() == null) ? "" : patientdet.Address.Zip.ToString();
                string statename = ((StateType)patientdet.Address.StateID).ToString();
                objP.State = (statename == null) ? "" : statename;
                objP.Age = (patientdet.PatientAge.ToString() == null) ? "" : patientdet.PatientAge.ToString();
                objP.GenderID = patientdet.GenderID.ToString();
                objP.DOB = patientdet.DOB.ToString("MM/dd/yyyy").Replace("-", "/");
                objP.CellPhone = (patientdet.CellPhoneNumber == null) ? "" : patientdet.CellPhoneNumber;
                objP.WorkPhoneNumber = (patientdet.WorkPhoneNumber == null) ? "" : patientdet.WorkPhoneNumber;
                objP.PharmcyPhone = (patientdet.PharmacyPhone == null) ? "" : patientdet.PharmacyPhone;
                string lastsubdate = "";
                PatientVitalSignsQO qoObjvital = new PatientVitalSignsQO() { PatientID = patient.ID };
                ObservableCollection<PatientVitalSign> objvitalSigns1 = new ObservableCollection<PatientVitalSign>();
                objvitalSigns1 = GetPatientVitalSigns(qoObjvital, false);

                if (objvitalSigns1.Count > 0)
                {
                    // CurrentVital = objvitalSigns.First();
                    //---- 27 Aug 2019 -- Patient Dashboard > Blue Boxes of Vital -- do not show vital which are added from CCM Review Page.. so check applied here
                    lastsubdate = objvitalSigns1.First(x => x.IsCCM == false).CreationDate.ToString("MM/dd/yyyy HH:mm:ss ttt");
                }
                objP.LastSubmittedVital = lastsubdate.Replace("-", "/");
                objP.LastSubmittedVital = (objP.LastSubmittedVital == null) ? "" : objP.LastSubmittedVital;
                if (objMedicalData.Count > 0)
                {
                    objP.HFClass = "Stage: " + objMedicalData[0].ACCHeartFailureStageID.ToString() + ", NYHA: " + objMedicalData[0].NYHAClassID.ToString() + ", E.F.: " + Math.Round(objMedicalData[0].EjectionFractionPercent) + "%";
                }
                PatientMedicationQO medicationQO = new PatientMedicationQO() { PatientID = patient.ID };
                var meds = new ObservableCollection<PatientMedication>(GetDLPatient().GetPatientMedication(medicationQO).ToList());
                var newmeds = meds.Select(x => new PatientMedicationRest { CreationDateLocalTime = x.CreationDateLocalTime.ToString(), LastUpdatedDateLocalTime = x.LastUpdatedDateLocalTime.ToString(), IsTherapy = x.IsTherapy, MedicationClassID = x.MedicationClassID, divColor = x.DivColor, Name = x.Name.ToUpper(), Amount = x.Amount.ToUpper(), Frequency = x.Frequency }).ToList();

                var maxCreateDt = newmeds.Max(x => x.CreationDateLocalTime);
                var maxUpdateDt = newmeds.Max(x => x.LastUpdatedDateLocalTime);
                if (Convert.ToDateTime(maxUpdateDt) < Convert.ToDateTime(maxCreateDt))
                {
                    maxUpdateDt = maxCreateDt;
                }
                objP.MedicationAsof = "AS OF: " + Convert.ToDateTime(maxUpdateDt).ToString("M-d-yyyy") + " @ " + Convert.ToDateTime(maxUpdateDt).ToString("h:mmtt").ToUpper();
                if (objP.MedicationAsof == "AS OF: 1-1-0001 @ 12:00AM")
                {
                    objP.MedicationAsof = "";
                }
                objP.MedicationAsof = (objP.MedicationAsof == null) ? "" : objP.MedicationAsof;
                objP.HFClass = objP.HFClass == null ? "" : objP.HFClass;
                PatientVitalLastest newpvl = new PatientVitalLastest();
                res.Record = (res.Record == null) ? newpvl : res.Record;
                VitalGoals newgoal = new VitalGoals();
                res.Goals = (res.Goals == null) ? newgoal : res.Goals;
                res.Info = objP;
                PatientHeaderInfoRest newpvr = new PatientHeaderInfoRest();
                res.Info = (res.Info == null) ? newpvr : res.Info;
                res.Status = "1";
                res.Message = "Success";
                return res;
            }
            catch (Exception ex)
            {
                res.Status = "0";
                res.Message = ex.Message;

                PatientVitalLastest newpvl = new PatientVitalLastest();
                res.Record = (res.Record == null) ? newpvl : res.Record;
                VitalGoals newgoal = new VitalGoals();
                res.Goals = (res.Goals == null) ? newgoal : res.Goals;

                PatientHeaderInfoRest newpvr = new PatientHeaderInfoRest();
                res.Info = (res.Info == null) ? newpvr : res.Info;
                return res;

            }
        }

        public Result SavePatientVatialSignsRest(PatientVitalSign vitals, IsManual items)
        {
            Result res = new Result();
            PatientVitalSign savedPatientVitals = null;
            try
            {
                if (vitals == null)
                    throw new ArgumentNullException();

                if (!GetPatientVitalSignStatus(new PersonQO() { ID = vitals.PatientID }))
                {
                    res.Status = "1";
                    res.Message = "Patient Heart Failue Data and Past Medical History must be entered before adding new vitals.";
                    return res;
                }
                //throw new ArgumentNullException("Patient Heart Failue Data and Past Medical History must be entered before adding new vitals.");

                savedPatientVitals = GetDLPatient().SavePatientVatialSignsRest(vitals, items);
                res.Status = "1";
                res.Message = "Success";
            }
            //catch (Exception ex)
            //{
            //    throw new FaultException<BusinessFaultDetail>(new BusinessFaultDetail("SavePatientVatialSigns Exception, See inner exception for details.", ex), new FaultReason("Error while saving patient vitals."));
            //}
            catch (FaultException<BusinessFaultDetail> faultException)
            {
                string message = faultException.Detail.CausedBy.Message;
                if (!string.IsNullOrEmpty(message))
                {
                    int index = message.LastIndexOf(":");
                    if (index > 0)
                    {
                        message = message.Substring(message.IndexOf(":") + 2);
                    }
                    if (message.Trim().ToLower() == "patient heart failue data and past medical history must be entered before adding new vitals.")
                    {
                        res.Status = "0";
                        res.Message = "Missing Data - Please contact your local clinic.";

                    }
                }
            }
            catch
            {
                res.Status = "0";
                res.Message = "failure";
            }

            //run the business rules here to see if an alert should be generated:
            return res;
        }
        public PatientAllergy SavePatientAllergy(PatientAllergy patientAllergy)
        {
            return GetDLPatient().SavePatientAllergy(patientAllergy);
        }
        public PatientInfoSummary GetPatientInfoSummary(PatientQO patientQO)
        {
            //initialize and load our objects
            PatientInfoSummary summary = new MyPulsario.Common.PatientInfoSummary();
            PatientDetail patient = this.GetPatientDemographics(patientQO);

            if (patient != null && patient.HomeCareProviderID != Guid.Empty)
            {
                User homeCareProvider = this.GetDLUser().GetUser(new UserQO() { UserID = patient.HomeCareProviderID });
                summary.HomeHealthProviderPhone = homeCareProvider.WorkPhoneNumber;
            }
            summary.PatientPhone = patient.PhoneNumber;
            summary.PatientCell = patient.CellPhoneNumber;
            summary.PharmacyPhone = patient.PharmacyPhone;

            try
            {
                ObservableCollection<PatientVitalSign> vitals = new ObservableCollection<PatientVitalSign>(this.GetPatientVitalSigns(new PatientVitalSignsQO() { PatientID = patientQO.ID }, false).Take(7));
                summary.Vitals = BuildVitalsMarkup(vitals);
            }
            catch
            {
                summary.Vitals = string.Empty;
            }

            try
            {
                ObservableCollection<PatientMedication> medsCurrent = this.GetPatientMedication(new PatientMedicationQO() { PatientID = patientQO.ID, IsArchivedFL = false });
                ObservableCollection<PatientMedication> archived = this.GetPatientMedication(new PatientMedicationQO() { PatientID = patientQO.ID, IsArchivedFL = true });
                summary.Medications = BuildMedicationsMarkup(medsCurrent, archived);
            }
            catch (Exception)
            {
                summary.Medications = string.Empty;
            }

            //Build our markup strings
            summary.Main = BuildPatientMarkup(patient);

            return summary;
        }
        private string BuildPatientMarkup(PatientDetail details)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(GetEnumDescription(MarkUp.HeaderStart) + "Patient Info" + GetEnumDescription(MarkUp.HeaderEnd));
            sb.Append(GetEnumDescription(MarkUp.BoldStart) + details.Name + " (DOB:  " + details.DOB.ToShortDateString() + ")" + GetEnumDescription(MarkUp.BoldEnd));
            sb.Append(GetEnumDescription(MarkUp.LineBreak));

            //Get Patient's Medical Data
            ObservableCollection<PatientMedicalData> patientMedicalDataList = this.GetPatientMedicalData(new PatientMedicalDataQO() { PatientID = details.ID });
            PatientMedicalData patientMedicalData = new MyPulsario.Common.PatientMedicalData();

            if (patientMedicalDataList != null && patientMedicalDataList.Count > 0)
            {
                patientMedicalData = patientMedicalDataList.OrderByDescending(x => x.LastUpdatedDate).First();
            }
            else
            {
                patientMedicalData = null;
            }

            sb.Append(GetEnumDescription(MarkUp.Divider));

            sb.Append(GetEnumDescription(MarkUp.SubHeaderStart) + "Heart Failure Data" + GetEnumDescription(MarkUp.SubHeaderEnd));

            sb.Append(GetEnumDescription(MarkUp.UnorderedListStart));
            if (patientMedicalData != null)
            {
                sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                sb.Append(GetEnumDescription(MarkUp.BoldStart) + "ACC Stage: " + GetEnumDescription(MarkUp.BoldEnd) + GetEnumDescription(MarkUp.GreySpanStart) + patientMedicalData.ACCHeartFailureStageID.ToString() + GetEnumDescription(MarkUp.SpanEnd));
                sb.Append(GetEnumDescription(MarkUp.ListItemEnd));

                sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                sb.Append(GetEnumDescription(MarkUp.BoldStart) + "NYHA Class: " + GetEnumDescription(MarkUp.BoldEnd) + GetEnumDescription(MarkUp.GreySpanStart) + patientMedicalData.NYHAClassID.ToString() + GetEnumDescription(MarkUp.SpanEnd));
                sb.Append(GetEnumDescription(MarkUp.ListItemEnd));

                sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                sb.Append(GetEnumDescription(MarkUp.BoldStart) + "Ejection Fraction: " + GetEnumDescription(MarkUp.BoldEnd) + GetEnumDescription(MarkUp.GreySpanStart) + patientMedicalData.EjectionFractionPercentAsString + GetEnumDescription(MarkUp.SpanEnd));
                sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
            }
            else
            {
                sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                sb.Append(GetEnumDescription(MarkUp.BoldStart) + "ACC Stage: " + GetEnumDescription(MarkUp.BoldEnd) + "N/A");
                sb.Append(GetEnumDescription(MarkUp.ListItemEnd));

                sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                sb.Append(GetEnumDescription(MarkUp.BoldStart) + "NYHA Class: " + GetEnumDescription(MarkUp.BoldEnd) + "N/A");
                sb.Append(GetEnumDescription(MarkUp.ListItemEnd));

                sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                sb.Append(GetEnumDescription(MarkUp.BoldStart) + "Ejection Fraction: " + GetEnumDescription(MarkUp.BoldEnd) + "N/A");
                sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
            }
            sb.Append(GetEnumDescription(MarkUp.UnorderedListEnd));

            sb.Append(GetEnumDescription(MarkUp.Divider));

            //Get Patient's Medical History
            ObservableCollection<PatientMedicalHistory> patientMedicalHistory = this.GetPatientMedicalHistory(new PatientMedicalHistoryQO() { PatientID = details.ID });

            sb.Append(GetEnumDescription(MarkUp.SubHeaderStart) + "Medical History" + GetEnumDescription(MarkUp.SubHeaderEnd));
            sb.Append(GetEnumDescription(MarkUp.UnorderedListStart));
            if (patientMedicalHistory != null && patientMedicalHistory.Count > 0)
            {
                foreach (PatientMedicalHistory m in patientMedicalHistory)
                {
                    sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                    sb.Append(GetEnumDescription(MarkUp.BoldStart));
                    sb.Append(m.MedicalHistoryTypeName);
                    sb.Append(GetEnumDescription(MarkUp.BoldEnd));
                    sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
                }
            }
            sb.Append(GetEnumDescription(MarkUp.UnorderedListEnd));

            sb.Append(GetEnumDescription(MarkUp.Divider));

            //Get Patient's Contact Info
            sb.Append(GetEnumDescription(MarkUp.SubHeaderStart) + "Contact" + GetEnumDescription(MarkUp.SubHeaderEnd));

            sb.Append(GetEnumDescription(MarkUp.UnorderedListStart));
            sb.Append(GetEnumDescription(MarkUp.ListItemStart));
            sb.Append(GetEnumDescription(MarkUp.BoldStart) + "Home Phone: " + GetEnumDescription(MarkUp.BoldEnd));
            sb.Append(GetEnumDescription(MarkUp.GreySpanStart));
            sb.Append(!string.IsNullOrEmpty(details.PhoneNumber) ? details.PhoneNumber : "N/A");
            sb.Append(GetEnumDescription(MarkUp.SpanEnd));
            sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
            sb.Append(GetEnumDescription(MarkUp.ListItemStart));
            sb.Append(GetEnumDescription(MarkUp.BoldStart) + "Mobile Phone: " + GetEnumDescription(MarkUp.BoldEnd));
            sb.Append(GetEnumDescription(MarkUp.GreySpanStart));
            sb.Append(!string.IsNullOrEmpty(details.CellPhoneNumber) ? details.CellPhoneNumber : "N/A");
            sb.Append(GetEnumDescription(MarkUp.SpanEnd));
            sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
            sb.Append(GetEnumDescription(MarkUp.ListItemStart));
            sb.Append(GetEnumDescription(MarkUp.BoldStart) + "Work Phone: " + GetEnumDescription(MarkUp.BoldEnd));
            sb.Append(GetEnumDescription(MarkUp.GreySpanStart));
            sb.Append(!string.IsNullOrEmpty(details.WorkPhoneNumber) ? details.WorkPhoneNumber : "N/A");
            sb.Append(GetEnumDescription(MarkUp.SpanEnd));
            sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
            sb.Append(GetEnumDescription(MarkUp.ListItemStart));
            sb.Append(GetEnumDescription(MarkUp.BoldStart) + "Pharmacy: " + GetEnumDescription(MarkUp.BoldEnd) + GetEnumDescription(MarkUp.GreySpanStart) + details.PharmacyName + " (");
            //sb.Append(!string.IsNullOrEmpty(details.PharmacyPhone) ? details.PharmacyPhone : "N/A" + ")");
            sb.Append(!string.IsNullOrEmpty(details.PharmacyPhone) ? details.PharmacyPhone + ")" : "N/A" + ")");
            sb.Append(GetEnumDescription(MarkUp.SpanEnd));
            sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
            sb.Append(GetEnumDescription(MarkUp.UnorderedListEnd));

            //Return the markup
            return sb.ToString();
        }
        private string BuildVitalsMarkup(ObservableCollection<PatientVitalSign> vitals)
        {
            StringBuilder sb = new StringBuilder();
            PatientClass patientClass = this.GetPatientGoals(new PersonQO() { ID = vitals[0].PatientID });

            PatientClassGoal pulseGoal = null;
            PatientClassGoal sbpGoal = null;
            PatientClassGoal dbpGoal = null;
            PatientClassGoal o2sGoal = null;
            PatientClassGoal weightGoal = null;

            sb.Append(GetEnumDescription(MarkUp.HeaderStart) + "Vitals" + GetEnumDescription(MarkUp.HeaderEnd));
            sb.Append(GetEnumDescription(MarkUp.Divider));

            if (patientClass.Goals != null)
            {
                pulseGoal = patientClass.Goals.Single(x => x.GoalTypeID == PatientClassGoalType.HeartRate);
                sbpGoal = patientClass.Goals.Single(x => x.GoalTypeID == PatientClassGoalType.SystolicBP);
                dbpGoal = patientClass.Goals.Single(x => x.GoalTypeID == PatientClassGoalType.DiastolicBP);
                o2sGoal = patientClass.Goals.Single(x => x.GoalTypeID == PatientClassGoalType.O2Sat);
                weightGoal = patientClass.Goals.Single(x => x.GoalTypeID == PatientClassGoalType.Weight);
                sb.Append(GetEnumDescription(MarkUp.SubHeaderStart) + "Reference Ranges" + GetEnumDescription(MarkUp.SubHeaderEnd));
                sb.Append(GetEnumDescription(MarkUp.UnorderedListStart));
                sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                sb.Append(GetEnumDescription(MarkUp.BoldStart) + "Pulse: " + GetEnumDescription(MarkUp.BoldEnd) + GetEnumDescription(MarkUp.GreySpanStart) + pulseGoal.Description + GetEnumDescription(MarkUp.SpanEnd));
                sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
                sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                sb.Append(GetEnumDescription(MarkUp.BoldStart) + "BP: " + GetEnumDescription(MarkUp.BoldEnd) + GetEnumDescription(MarkUp.GreySpanStart) + sbpGoal.Description + "/" + dbpGoal.Description + GetEnumDescription(MarkUp.SpanEnd));
                sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
                sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                sb.Append(GetEnumDescription(MarkUp.BoldStart) + "O<sub style='font-size:0.75em;'>2</sub> Sat: " + GetEnumDescription(MarkUp.BoldEnd) + GetEnumDescription(MarkUp.GreySpanStart) + o2sGoal.Description + GetEnumDescription(MarkUp.SpanEnd));
                sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
                sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                sb.Append(GetEnumDescription(MarkUp.BoldStart) + "Weight: " + GetEnumDescription(MarkUp.BoldEnd) + GetEnumDescription(MarkUp.GreySpanStart) + weightGoal.Description + GetEnumDescription(MarkUp.SpanEnd));
                sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
                sb.Append(GetEnumDescription(MarkUp.UnorderedListEnd));
            }
            else
            {
                sb.Append(GetEnumDescription(MarkUp.SubHeaderStart) + "Reference Ranges" + GetEnumDescription(MarkUp.SubHeaderEnd));
                sb.Append(GetEnumDescription(MarkUp.UnorderedListStart));
                sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                sb.Append(GetEnumDescription(MarkUp.BoldStart) + "Pulse: " + GetEnumDescription(MarkUp.BoldEnd) + GetEnumDescription(MarkUp.GreySpanStart) + "N/A" + GetEnumDescription(MarkUp.SpanEnd));
                sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
                sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                sb.Append(GetEnumDescription(MarkUp.BoldStart) + "BP: " + GetEnumDescription(MarkUp.BoldEnd) + GetEnumDescription(MarkUp.GreySpanStart) + "N/A" + GetEnumDescription(MarkUp.SpanEnd));
                sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
                sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                sb.Append(GetEnumDescription(MarkUp.BoldStart) + "O<sub style='font-size:0.75em;'>2</sub> Sat: " + GetEnumDescription(MarkUp.BoldEnd) + GetEnumDescription(MarkUp.GreySpanStart) + "N/A" + GetEnumDescription(MarkUp.SpanEnd));
                sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
                sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                sb.Append(GetEnumDescription(MarkUp.BoldStart) + "Weight: " + GetEnumDescription(MarkUp.BoldEnd) + GetEnumDescription(MarkUp.GreySpanStart) + "N/A" + GetEnumDescription(MarkUp.SpanEnd));
                sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
                sb.Append(GetEnumDescription(MarkUp.UnorderedListEnd));
            }

            sb.Append(GetEnumDescription(MarkUp.Divider));
            sb.Append(GetEnumDescription(MarkUp.SubHeaderStart) + "Vital Sign History" + GetEnumDescription(MarkUp.SubHeaderEnd));

            sb.Append(GetEnumDescription(MarkUp.UnorderedListStart));
            if (vitals != null)
            {
                ObservableCollection<LookUpItem> qolScore = this.GetDLLookUp().GetLookUpValues(new MasterLookUpQO() { TableType = LuTableType.LuPatientQOLScore });
                ObservableCollection<LookUpItem> activityScore = this.GetDLLookUp().GetLookUpValues(new MasterLookUpQO() { TableType = LuTableType.LuPatientActivityScore });

                foreach (PatientVitalSign v in vitals)
                {
                    sb.Append(GetEnumDescription(MarkUp.ListItemStart));

                    sb.Append(GetEnumDescription(MarkUp.BoldStart));
                    sb.Append(v.CreationDateLocalTime.ToString());
                    sb.Append(GetEnumDescription(MarkUp.BoldEnd));
                    sb.Append(GetEnumDescription(MarkUp.LineBreak));

                    sb.Append("Pulse: " + GetEnumDescription(MarkUp.GreySpanStart) + v.Pulse + GetEnumDescription(MarkUp.SpanEnd));
                    sb.Append("  BP: ");
                    if (v.SystolicPressure == "N/A" && v.DiastolicPressure == "N/A")
                        sb.Append("N/A");
                    else
                    {
                        sb.Append(GetEnumDescription(MarkUp.GreySpanStart) + v.SystolicPressure);
                        sb.Append("/");
                        sb.Append(v.DiastolicPressure + GetEnumDescription(MarkUp.SpanEnd));
                    }
                    sb.Append(GetEnumDescription(MarkUp.LineBreak));

                    sb.Append("O<sub style='font-size:0.75em;'>2</sub> Sat: " + GetEnumDescription(MarkUp.GreySpanStart) + v.O2Sat + GetEnumDescription(MarkUp.SpanEnd));
                    sb.Append("  Weight: " + GetEnumDescription(MarkUp.GreySpanStart) + v.Weight + GetEnumDescription(MarkUp.SpanEnd));
                    sb.Append(GetEnumDescription(MarkUp.LineBreak));

                    sb.Append("Quality of Life: " + GetEnumDescription(MarkUp.GreySpanStart) + displayLuString(qolScore, v.QualityOfLifeID) + GetEnumDescription(MarkUp.SpanEnd));
                    sb.Append(GetEnumDescription(MarkUp.LineBreak));

                    sb.Append("Daily Activity: " + GetEnumDescription(MarkUp.GreySpanStart) + displayLuString(activityScore, v.ActivityID) + GetEnumDescription(MarkUp.SpanEnd));

                    sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
                }
            }
            sb.Append(GetEnumDescription(MarkUp.UnorderedListEnd));

            return sb.ToString();
        }

        private String displayLuString(ObservableCollection<LookUpItem> lu, int v)
        {
            LookUpItem item = lu.SingleOrDefault(x => x.ID == v);
            if (item == null)
                return "(N/A)";
            else
                return item.Name;
        }

        private string BuildMedicationsMarkup(ObservableCollection<PatientMedication> medsCurrent, ObservableCollection<PatientMedication> medsArchived)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(GetEnumDescription(MarkUp.HeaderStart) + "Medications" + GetEnumDescription(MarkUp.HeaderEnd));
            sb.Append(GetEnumDescription(MarkUp.Divider));

            if (medsCurrent != null)
            {
                IEnumerable<PatientMedication> prescribed = medsCurrent.Where(x => x.MedicationReasonTypeID == (Int32)MedicationReasonType.None);
                IEnumerable<PatientMedication> notPrescribed = medsCurrent.Where(x => x.MedicationReasonTypeID == (Int32)MedicationReasonType.Not_currently_prescribed || x.MedicationReasonTypeID == (Int32)MedicationReasonType.Not_indicated_for_this_patient);
                IEnumerable<PatientMedication> contra = medsCurrent.Where(x => x.MedicationReasonTypeID == (Int32)MedicationReasonType.Previous_adverse_reaction_or_intolerance || x.MedicationReasonTypeID == (Int32)MedicationReasonType.Allergy_to_Medication);


                if (prescribed.Count() > 0)
                {
                    sb.Append(GetEnumDescription(MarkUp.SubHeaderStart) + "Currently Prescribed" + GetEnumDescription(MarkUp.SubHeaderEnd));
                    sb.Append(GetEnumDescription(MarkUp.UnorderedListStart));

                    foreach (PatientMedication m in prescribed)
                    {
                        sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                        MedicationToStringBuilder(sb, m);
                        sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
                    }
                    sb.Append(GetEnumDescription(MarkUp.UnorderedListEnd));
                }

                if (notPrescribed.Count() > 0)
                {
                    sb.Append(GetEnumDescription(MarkUp.SubHeaderStart) + "Not Prescribed" + GetEnumDescription(MarkUp.SubHeaderEnd));
                    sb.Append(GetEnumDescription(MarkUp.UnorderedListStart));

                    foreach (PatientMedication m in notPrescribed)
                    {
                        sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                        MedicationToStringBuilder(sb, m);
                        sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
                    }
                    sb.Append(GetEnumDescription(MarkUp.UnorderedListEnd));
                }

                if (contra.Count() > 0)
                {
                    sb.Append(GetEnumDescription(MarkUp.SubHeaderStart) + "Contraindicated" + GetEnumDescription(MarkUp.SubHeaderEnd));
                    sb.Append(GetEnumDescription(MarkUp.UnorderedListStart));

                    foreach (PatientMedication m in contra)
                    {
                        sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                        MedicationToStringBuilder(sb, m);
                        sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
                    }
                    sb.Append(GetEnumDescription(MarkUp.UnorderedListEnd));
                }

                if (medsArchived.Count() > 0)
                {
                    sb.Append(GetEnumDescription(MarkUp.SubHeaderStart) + "Archived" + GetEnumDescription(MarkUp.SubHeaderEnd));
                    sb.Append(GetEnumDescription(MarkUp.UnorderedListStart));

                    foreach (PatientMedication m in medsArchived)
                    {
                        sb.Append(GetEnumDescription(MarkUp.ListItemStart));
                        MedicationToStringBuilder(sb, m);
                        sb.Append(GetEnumDescription(MarkUp.ListItemEnd));
                    }
                    sb.Append(GetEnumDescription(MarkUp.UnorderedListEnd));
                }

            }


            return sb.ToString();
        }

        private void MedicationToStringBuilder(StringBuilder sb, PatientMedication m)
        {
            ObservableCollection<LookUpItem> medReasons = this.GetDLLookUp().GetLookUpValues(new MasterLookUpQO() { TableType = LuTableType.LuMedicationTypeReason });

            sb.Append(string.IsNullOrWhiteSpace(m.Name) ? GetEnumDescription(MarkUp.BoldStart) + m.MedicationClassName + GetEnumDescription(MarkUp.BoldEnd) : GetEnumDescription(MarkUp.BoldStart) + m.Name + GetEnumDescription(MarkUp.BoldEnd));

            if (!string.IsNullOrWhiteSpace(m.Amount))
                sb.Append(", " + m.Amount);
            if (!string.IsNullOrWhiteSpace(m.Frequency))
                sb.Append(", " + m.Frequency);
            LookUpItem reason = medReasons.FirstOrDefault(x => x.ID == m.MedicationReasonTypeID);
            if (reason != null && reason.Name != "Not currently prescribed" && reason.Name != "Not indicated for this patient")
                sb.Append(" [" + reason.Name + "]");
            if (m.IsArchived)
            {
                sb.Append(GetEnumDescription(MarkUp.LineBreak));
                sb.Append("Archived: " + GetEnumDescription(MarkUp.GreySpanStart) + m.ArchivedDate.ToShortDateString() + GetEnumDescription(MarkUp.SpanEnd));
                sb.Append(GetEnumDescription(MarkUp.LineBreak));
                sb.Append("Comments: " + GetEnumDescription(MarkUp.GreySpanStart) + m.Comments + GetEnumDescription(MarkUp.SpanEnd));
            }


        }
        private enum MarkUp
        {
            [Description("<br />")]
            LineBreak,
            [Description("<span style='color:grey;'>")]
            GreySpanStart,
            [Description("</span>")]
            SpanEnd,
            [Description("<hr style='color:lightgrey; height:1px;' />")]
            Divider,
            [Description("<h2 style='font-family:Avenir Next Regular; margin-bottom:0px;'>")]
            HeaderStart,
            [Description("</h2>")]
            HeaderEnd,
            [Description("<ol>")]
            OrderedListStart,
            [Description("</ol>")]
            OrderedListEnd,
            [Description("<li style='padding-top:15px'>")]
            ListItemStart,
            [Description("</li>")]
            ListItemEnd,
            [Description("<p>")]
            ParagraphStart,
            [Description("</p>")]
            ParagraphEnd,
            [Description("<span style='font-family:Avenir Next Medium;'>")]
            BoldStart,
            [Description("</span>")]
            BoldEnd,
            [Description("<ul style='list-style:none; padding:0; margin-top:0; font-family:Avenir Next Regular;'>")]
            UnorderedListStart,
            [Description("</ul>")]
            UnorderedListEnd,
            [Description("<h3 style='color:#69aab3; letter-spacing:1px; font-family:Avenir Next Regular; margin-top:10px; margin-bottom:10px;'>")]
            SubHeaderStart,
            [Description("</h3>")]
            SubHeaderEnd,
        }
        private static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }

        public PatientDetail GetPatientDemographics(PatientQO patientQO)
        {
            if (patientQO == null || patientQO.ID == Guid.Empty)
                throw new ArgumentNullException();



            PatientDetail patient = GetDLPatient().GetPatientDemographics(patientQO);
            if (patient != null)
            {
                //TODO: Brian
                patient.SSN = this.DecryptString(patient.SSN);
                patient.PatientId = patientQO.ID;
            }

            return patient;
        }

        public ObservableCollection<PatientVitalSign> GetPatientVitalSigns(PatientVitalSignsQO vitalsQO, bool IsCCM)
        {
            ObservableCollection<PatientVitalSign> vitals = GetDLPatient().GetPatientVitalSigns(vitalsQO, IsCCM);
            return vitals;
        }
        public PatientVitalSign SavePatientVatialSigns(PatientVitalSign vitals)
        {
            PatientVitalSign savedPatientVitals = null;
            try
            {
                if (vitals == null)
                    throw new ArgumentNullException();

                if (!GetPatientVitalSignStatus(new PersonQO() { ID = vitals.PatientID }))
                    throw new ArgumentNullException("Patient Heart Failure Data and Past Medical History must be entered before adding new vitals.");

                savedPatientVitals = GetDLPatient().SavePatientVatialSigns(vitals);
            }
            catch (Exception ex)
            {
                throw new FaultException<BusinessFaultDetail>(new BusinessFaultDetail("SavePatientVatialSigns Exception, See inner exception for details.", ex), new FaultReason("Error while saving patient vitals."));
            }

            //run the business rules here to see if an alert should be generated:
            return savedPatientVitals;
        }

        public decimal GetPatientDryWeight(PatientQO patientQO)
        {
            return GetDLPatient().GetPatientDryWeight(patientQO);
        }

        public PatientMedication SavePatientMedication(PatientMedication patientMed)
        {
            PatientMedication savedPatientMedication = GetDLPatient().SavePatientMedication(patientMed);
            return savedPatientMedication;
        }

        public void SavePatientDryWeight(PatientVitalSignsQO vitalQO)
        {
            GetDLPatient().SavePatientDryWeight(vitalQO);
        }
        public bool GetPatientVitalSignStatus(PersonQO qoObj)
        {
            return GetDLPatient().GetPatientVitalSignStatus(qoObj);
        }
        public int CheckProgamType(Guid ID)
        {
            return GetDLPatient().CheckProgamType(ID);
        }


        public ObservableCollection<Person> GetPrimaryCareProviderList(CommonQO commonQO)
        {
            if (commonQO == null || commonQO.OrganizationID == Guid.Empty)
                throw new ArgumentNullException();

            return GetDLPatient().GetPrimaryCareProviderList(commonQO);
        }

        public ObservableCollection<PatientListModel> GetPatientList(Guid ID, string loginusername, string firstname, string lastname, string dob, PatientSearchModel model)
        {

            return GetDLPatient().GetPatientList(ID,loginusername, firstname, lastname, dob, model);
        }
        public ObservableCollection<PatientListModel> GetPatientListForAdmin(Guid ID, string firstname, string lastname, string dob, PatientSearchModel model, bool Isall)
        {

            return GetDLPatient().GetPatientListForAdmin(ID, firstname, lastname, dob, model, Isall);
        }

        public bool UpdateStatus(string ids, string status, string tablename, string primaryColumn, Guid modifyByID)
        {
            return this.GetDLPatient().UpdateStatus(ids, status, tablename, primaryColumn, modifyByID);
        }

        public ObservableCollection<AdditionalProvider> GetAdditionalProviderList(PersonQO personQO)
        {
            ObservableCollection<AdditionalProvider> additionalProviderList =
               GetDLPatient().GetAdditionalProviderList(personQO);
            return additionalProviderList;
        }

        public PatientDetail SavePatientDemographics(PatientDetail patient, string allAdditionalProviders)
        {
            try
            {
                //if registering new patient, create useraccount:
                if (patient.ID == Guid.Empty)
                {
                    bool isapproved = false;
                    if (patient.ProgramType == 1 || patient.ProgramType == 3)
                    {
                        isapproved = true;
                    }
                    //creates the membership and sends an email:
                    patient.ID = new BLUser().CreateUser(patient, "Patient", isActive: isapproved);

                    if (patient.ID != Guid.Empty & patient.HomeCareAgencyID != Guid.Empty)
                    {
                        GetBLCommunication().SendHomeCareAdminEmail(patient);
                    }

                }

                //encrypt SSN:
                if (!String.IsNullOrWhiteSpace(patient.SSN))
                {
                    //Encrypt SSN:
                    //TODO:Brian-
                    patient.SSN = this.EncryptString(patient.SSN);
                }

                patient = GetDLPatient().SavePatientDemographics(patient, allAdditionalProviders);
            }
            catch (Exception ex)
            {

                throw new FaultException<BusinessFaultDetail>(new BusinessFaultDetail("SavePatientDemos Exception, See inner exception for details.", ex), new FaultReason(ex.Message));

            }
            return patient;
        }

        public ObservableCollection<PatientMedicalHistory> GetPatientMedicalHistory(PatientMedicalHistoryQO medHistoryQO)
        {
            ObservableCollection<PatientMedicalHistory> medHistory =
                GetDLPatient().GetPatientMedicalHistory(medHistoryQO);
            return medHistory;
        }
        public Person SavePrimaryCareProvider(Person primaryCareProvider)
        {
            if (primaryCareProvider == null)
                throw new ArgumentNullException();

            return GetDLPatient().SavePrimaryCareProvider(primaryCareProvider);
        }
        public PatientICDDeviceOption GetPatientICDDeviceOption(Guid patientID)
        {
            return GetDLPatient().GetPatientICDDeviceOption(patientID);
        }
        public PatientMedicalHistory SavePatientMedicalHistory(PatientMedicalHistory medicalHistory)
        {
            PatientMedicalHistory savedPatientMedicalHistory = GetDLPatient().SavePatientMedicalHistory(medicalHistory);
            return savedPatientMedicalHistory;
        }

        public ObservableCollection<MedicationDose> GetDoseByMedication(int medicationID)
        {
            return GetDLPatient().GetDoseByMedication(medicationID);
        }
        public ObservableCollection<Medication> GetMedicationsByClass(int classID)
        {
            return GetDLPatient().GetMedicationsByClass(classID);
        }
        public PatientSocialHistory SavePatientSocialHistory(PatientSocialHistory socialHistory)
        {
            PatientSocialHistory savedPatientSocialHistory = GetDLPatient().SavePatientSocialHistory(socialHistory);
            return savedPatientSocialHistory;
        }

        public void DeletePatientMedicalHistory(PatientMedicalHistoryQO medHistoryQO)
        {
            GetDLPatient().DeletePatientMedicalHistory(medHistoryQO);
        }

        public Result DeletePatientMedicalHistoryRest(string id)
        {
            Result res = new Result();
            if (string.IsNullOrEmpty(id))
            {
                res.Message = "Fail";
                res.Status = "0";
            }
            try
            {
                PatientMedicalHistoryQO medHistoryQO = new PatientMedicalHistoryQO();
                medHistoryQO.ID = Guid.Parse(id);
                GetDLPatient().DeletePatientMedicalHistory(medHistoryQO);
                res.Message = "Successful";
                res.Status = "1";
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
                res.Status = "0";
            }
            return res;
        }
        public void SavePatientICDDeviceOption(PatientICDDeviceOption option)
        {
            GetDLPatient().SavePatientICDDeviceOption(option);
        }
        public ObservableCollection<PatientSocialHistory> GetPatientSocialHistory(PatientSocialHistoryQO socialHistoryQO)
        {
            ObservableCollection<PatientSocialHistory> socHistory =
                GetDLPatient().GetPatientSocialHistory(socialHistoryQO);
            return socHistory;
        }

        //20-05-2019
        public ObservableCollection<Patient> SearchPatient(SearchPersonQO searchQO)
        {
            if (searchQO != null)
            {
                searchQO.RoleName = "patient";
                return GetDLPatient().SearchPatient(searchQO);
            }
            else

                throw new ArgumentNullException();
        }

        public ObservableCollection<PatientCareFacilityVisit> GetPatientCareFacilityVisits(
      PatientCareFacilityVisitsQO visitsQO)
        {
            ObservableCollection<PatientCareFacilityVisit> visits = GetDLPatient()
                .GetPatientCareFacilityVisits(visitsQO);
            return visits;
        }

        public PatientCareFacilityVisit SavePatientCareFacilityVisit(PatientCareFacilityVisit visit)
        {
            PatientCareFacilityVisit savedPatientFacilityVisit = GetDLPatient().SavePatientCareFacilityVisit(visit);
            return savedPatientFacilityVisit;
        }

        public void DeletePatientCareFacilityVisit(PatientCareFacilityVisitsQO visitQO)
        {
            GetDLPatient().DeletePatientCareFacilityVisit(visitQO);
        }

        public ObservableCollection<DropdownListItems> GetPatients(string type, Guid? organizationID)
        {


            return GetDLPatient().GetPatients(type, organizationID);
        }


        public ObservableCollection<DropdownListItems> GetNonClinicPatient(string type, Guid? organizationID)
        {


            return GetDLPatient().GetNonClinicPatient(type, organizationID);
        }

        public PatientClass GetPatientGoals(PersonQO ptQO)
        {
            if (ptQO == null || ptQO.ID == Guid.Empty)
                throw new ArgumentNullException();

            return GetDLPatient().GetPatientGoals(ptQO);

        }
        #region Patient Chart
        public ObservableCollection<PatientVitalSign> GetPatientVitalSignsList(PatientVitalSignsQO vitalsQO,int days=7)
        {
            ObservableCollection<PatientVitalSign> vitals = GetDLPatient().GetPatientVitalSignsList(vitalsQO, days);
            return vitals;
        }




        #endregion
        #region Patient Appointments List
        public ObservableCollection<CCMReviewAppointmentModel> GetPatientAppointmentList(System.Guid? patientID, System.Guid? OrganizationId)
        {
            ObservableCollection<CCMReviewAppointmentModel> PatientAppointments = GetDLPatient().GetPatientAppointmentList(patientID, OrganizationId);
            return PatientAppointments;
        }
        #endregion
        public ObservableCollection<PatientListModel> GetPatientListCNA(Guid ID, string firstname, string lastname, string dob, PatientSearchModel model)
        {

            return GetDLPatient().GetPatientListCNA(ID, firstname, lastname, dob, model);
        }



        public ObservableCollection<PatientMyAppointmentModel> GetPatientMyAppointments(PatientMyAppointmentsSearchModel model)
        {
            return GetDLPatient().GetPatientMyAppointments(model);
        }

        public void SendAppointmentRescheduleMail(string nurseName, string nurseEMail, string patientName, string appointmentDate, string appoiintmentTime, string requstType, string comment)
        {
            new BLCommunication().PatientAppointmentRescheduleCancelRequest(nurseName, nurseEMail, patientName, appointmentDate, appoiintmentTime, requstType, comment);
        }


        #region reports finalize
        public void UpdateDailyVitalTime(Guid? id, Guid? pid, string selvalue)
        {
            GetDLPatient().UpdateDailyVitalTime(id, pid, selvalue);
        }

        public Result UpdateDailyVitalTimeRest(string id, string pid, string selvalue)
        {
            Result res = new Result();
            if (pid == "")
            {
                res.Status = "0";
                res.Message = "Fail";

                return res;
            }
            GetDLPatient().UpdateDailyVitalTime(Guid.Parse(!string.IsNullOrEmpty(id) ? id : Guid.Empty.ToString()), Guid.Parse(!string.IsNullOrEmpty(pid) ? pid : Guid.Empty.ToString()), selvalue);

            res.Status = "1";
            res.Message = "Success";
            return res;
        }

        public VerifyReport PasscodeverificationRest(string oid, string pid, bool isdailyreport)
        {
            VerifyReport res = new VerifyReport();
            if (!isdailyreport)
            {
                var report = GetPatientReportWithVitals(Guid.Parse(oid), Guid.Parse(pid));
                int count = report.Where(m => m.VerifyVital == "False" && m.VitalDate.ToString() != "1/1/1753 12:00:00 AM").Count();
                UserSignature obj = GetDLUser().GetSignature(Guid.Parse(pid));
                //var result = new { Result = obj, Dailyreport = count,rpt= report.LastOrDefault().VitalDate.ToString() };
                res.Dailyreport = count;
                res.Passcode = obj.Passcode;
                res.SignatureFile = obj.SignatureFile;


            }
            else
            {
                UserSignature obj = GetDLUser().GetSignature(Guid.Parse(pid));
                res.Passcode = obj.Passcode;
                res.SignatureFile = obj.SignatureFile;

            }
            res.Status = "1";
            res.Message = "Success";
            return res;
        }

        public void UpdateDailyVitalTimeForAll(string ids)
        {
            GetDLPatient().UpdateDailyVitalTimeForAll(ids);
        }

        public Result UpdateDailyVitalTimeAllRest(string ids)
        {
            Result res = new Result();
            if (string.IsNullOrEmpty(ids))
            {
                res.Message = "Fail";
                res.Status = "0";

            }
            try
            {
                GetDLPatient().UpdateDailyVitalTimeForAll(ids);
                res.Message = "Successful";
                res.Status = "1";

            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
                res.Status = "0";
            }
            return res;
        }
        #endregion

        /// <summary>
        /// To get all patient report for the given clinic on evry last day of month, this will call in scheduler
        /// </summary>
        /// <param name="OtgID"> pass organization id to get patient list under that clinic</param>
        /// <returns></returns>
        public ObservableCollection<PatientReport> GetPatientReport(Guid OrgID, string startdate, string enddate)//, string complexitylevel=""
        {
            ObservableCollection<PatientReport> Patientlist = GetDLPatient().GetPatientReport(OrgID, startdate, enddate);//, complexitylevel);
            return Patientlist;
        }

        /// <summary>
        /// To get all patient report for the given clinic on evry last day of month, this will call in scheduler
        /// </summary>
        /// <param name="OtgID"> pass organization id to get patient list under that clinic</param>
        /// <returns></returns>
        public ObservableCollection<PatientReportRest> GetPatientReportRest(Guid OrgID, string startdate, string enddate)
        {
            ObservableCollection<PatientReportRest> Patientlist = GetDLPatient().GetPatientReportRest(OrgID, startdate, enddate);
            return Patientlist;
        }

        public ProviderBasicData GetProviderBasicData(Guid OrgID)
        {
            ProviderBasicData Patientlist = GetDLPatient().GetProviderBasicData(OrgID);
            return Patientlist;

        }
            public ObservableCollection<PatientReportWithVitals> GetPatientReportWithVitalsForCurrentMonth(int month)
        {
            ObservableCollection<PatientReportWithVitals> Patientlist = GetDLPatient().GetPatientReportWithVitalsForCurrentMonth(month);
            return Patientlist;
        }
        public void FinalizeMonthlyReport(Guid id, string startdate, string enddate)
        {
            GetDLPatient().FinalizeMonthlyReport(id, startdate, enddate);
        }

        public Result FinalizeMonthlyReportRest(string id)
        {
            Result res = new Result();
            if (string.IsNullOrEmpty(id))
            {
                res.Message = "Fail";
                res.Status = "0";
            }
            try
            {
                DateTime now = DateTime.Now;
                var startDate1 = new DateTime(now.Year, now.Month, 1);
                var enddate1 = new DateTime(now.Year, now.Month, now.Day);
                string startdate = getServerStandardDateFormat(startDate1.ToString()).ToString();
                string enddate = getServerStandardDateFormat(enddate1.ToString()).ToString();
                GetDLPatient().FinalizeMonthlyReport(Guid.Parse(id), startdate, enddate);
                res.Message = "Successful";
                res.Status = "1";
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
                res.Status = "0";
            }
            return res;
        }
        public CCMCompletedRest CCMCompletedReviewRest(string pid,string oid, string appointmentdate)
        {
            CCMCompletedRest res = new CCMCompletedRest();
            if (string.IsNullOrEmpty(pid) || string.IsNullOrEmpty(appointmentdate))
            {
                res.completedReview = new CCMReviewDashobardRest();
                res.Message = "Fail";
                res.Status = "0";
            }
            try
            {
                CCMReviewDashobardRest completedReview = new CCMReviewDashobardRest();
                /**************/
                DateTime apointDat = (appointmentdate == null) ? DateTime.Parse(DateTime.Now.Date.ToString()) : DateTime.Parse(appointmentdate.ToString());
                completedReview = GetDLNurse().GetPatientCompletedReviewDataRest(Guid.Parse(pid), getServerStandardDateFormat(appointmentdate), Guid.Parse(oid));
                completedReview.PatientID = (pid);
                res.completedReview = completedReview;
                res.Message = "Successful";
                res.Status = "1";
            }
            catch (Exception ex)
            {
                res.completedReview = new CCMReviewDashobardRest();
                res.Message = ex.Message;
                res.Status = "0";
            }
            return res;
        }

        public Result GetLastDayofMonth()
        {
            Result res = new Result();

            try
            {


                var lastDayOfMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                bool isLastDayOfMonth = (lastDayOfMonth == DateTime.Now.Day);
                if (isLastDayOfMonth)
                {
                    res.Message = "Successful";
                    res.Status = "1";
                }
                else
                {
                    res.Message = "Fail";
                    res.Status = "0";
                   // res.Message = "Successful";
                   // res.Status = "1";
                }
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
                res.Status = "0";
            }
            return res;
        }
        public ObservableCollection<Country> GetCountryCode()
        {
            ObservableCollection<Country> cntlist = this.GetDLPatient().GetCountryCode();
            return cntlist;
        }
        public ObservableCollection<PatientAdditionalProvidersDetail> GetPatientAdditionalProviders(Guid patientID)
        {

            ObservableCollection<PatientAdditionalProvidersDetail> adProList = this.GetDLPatient().GetPatientAdditionalProviders(patientID);
            return adProList;
        }
        public bool DeletePCP(Guid ID)
        {
            return GetDLPatient().DeletePCP(ID);
        }
        public bool DeleteAdditionalProvider(Guid ID)
        {
            return GetDLPatient().DeleteAdditionalProvider(ID);
        }

        public PatientICDDeviceOption GetPatientICDDeviceOptionRest(string patientID)
        {
            return GetDLPatient().GetPatientICDDeviceOption(Guid.Parse(patientID));
        }


        public PatientListResult GetPatientListCNARest(string ID, string firstname, string lastname, string dob, PatientSearchModel model)
        {
            PatientListResult res = new PatientListResult();
            if (string.IsNullOrEmpty(ID))
            {
                res.Status = "0";
                res.Message = "id is empty";
                res.Record = null;
                return res;
            }

            if (!string.IsNullOrEmpty(ID))
            {

                ObservableCollection<PatientListModelRest> rec = GetDLPatient().GetPatientListCNARest(Guid.Parse(ID), firstname, lastname, dob, model);
                res.Status = "1";
                res.Message = "Success";
                res.Record = rec;
                return res;
            }
            else
            {
                res.Status = "0";
                res.Message = "id is empty";
                res.Record = null;
                return res;
            }
        }

        public PatientListResult GetPatientListRest(string ID, string orgID, string firstname, string lastname, string dob, PatientSearchModel model)
        {
            PatientListResult res = new PatientListResult();
            if (string.IsNullOrEmpty(ID))
            {
                res.Status = "0";
                res.Message = "id is empty";
                res.Record = null;
                return res;
            }

            if (!string.IsNullOrEmpty(ID))
            {

                ObservableCollection<PatientListModelRest> rec = GetDLPatient().GetPatientListRest(Guid.Parse(ID), Guid.Parse(orgID), firstname, lastname, dob, model);
                res.Status = "1";
                res.Message = "Success";
                res.Record = rec;
                return res;
            }
            else
            {
                res.Status = "0";
                res.Message = "id is empty";
                res.Record = null;
                return res;
            }
        }
        public PatientProfileResult GetPatientDemographicsRest(PatientQO patientQO)
        {
            PatientProfileResult res = new PatientProfileResult();
            if (patientQO == null || patientQO.ID == Guid.Empty)
            {
                res.Status = "0";
                res.Message = "Patient id is empty";
                res.Record = null;
                return res;
            }

            PatientDetail patient = GetDLPatient().GetPatientDemographics(patientQO);
            if (patient != null && patient.ID != Guid.Empty)
            {

                PatientProfile prof = new PatientProfile();
                prof.FirstName = patient.FirstName;
                prof.LastName = patient.LastName;
                prof.DOB = patient.DOB.ToString("MM/dd/yyyy");
                prof.Email = patient.EmailAddress;
                prof.HomePhone = (patient.PhoneNumber == null) ? "" : patient.PhoneNumber;
                prof.CellPhone = (patient.CellPhoneNumber == null) ? "" : patient.CellPhoneNumber;
                prof.PharmcyPhone = (patient.PharmacyPhone == null) ? "" : patient.PharmacyPhone;
                prof.WorkPhoneNumber = (patient.WorkPhoneNumber == null) ? "" : patient.WorkPhoneNumber;
                prof.Address = Convert.ToString(patient.Address.Street1);
                prof.City = Convert.ToString(patient.Address.City);
                prof.Zip = Convert.ToString(patient.Address.Zip);
                prof.State = ((StateType)Convert.ToInt32(patient.Address.StateID)).ToString();
                res.Record = prof;
                res.Status = "1";
                res.Message = "Success.";
                return res;

            }
            else
            {
                res.Status = "0";
                res.Message = "No record found for this patient.";
                res.Record = null;
                return res;
            }
        }
        public PatientDataForProvider GetPatientInfoforProviderRest(string patientid)
        {

            var res = GetDLPatient().GetPatientInfoforProviderRest(patientid);
            return res;
        }

        public Result CheckMedicalHistoryForVitalRest(string PatientID)
        {
            Result result = new Result();
            try
            {
                result.Status = "1";
                result.Message = "Success";
                if (!GetPatientVitalSignStatus(new PersonQO() { ID = Guid.Parse(PatientID) }))
                {
                    result.Status = "0";
                    result.Message = "Patient Heart Failure Data and Past Medical History must be entered before adding new vitals.";

                }
            }
            catch (Exception ex)
            {
                result.Status = "0";
                result.Message = "Something is wrong.";

            }
            return result;
        }


        public PatientMedicationResult MedicationListDataRest(string patientid, string classID)
        {
            PatientMedicationResult res = new PatientMedicationResult();
            if (string.IsNullOrEmpty(patientid))
            {
                res.Status = "0";
                res.Message = "id is empty";
                List<PatientMedicationDataRest> Medications = new List<PatientMedicationDataRest>();
                res.Medications = Medications;
                List<DropdownItems> classses = new List<DropdownItems>();
                res.Classes = classses;
                List<Medication> drugs = new List<Medication>();
                res.Drugs = drugs;
                List<DropdownItemsRecipient> freq = new List<DropdownItemsRecipient>();
                res.Frequency = freq;
                var patientdet = GetPatientDemographics(new PatientQO() { ID = new Guid(patientid.Trim()) });
                PatientHeaderInfoRest objP = new PatientHeaderInfoRest();
                objP.City = (patientdet.Address.City == null) ? "" : patientdet.Address.City;
                objP.Address = (patientdet.Address.Street1 == null) ? "" : patientdet.Address.Street1;
                objP.Zip = (patientdet.Address.Zip.ToString() == null) ? "" : patientdet.Address.Zip.ToString();
                string statename = ((StateType)patientdet.Address.StateID).ToString();
                objP.State = (statename == null) ? "" : statename;
                objP.Age = patientdet.PatientAge.ToString();
                objP.GenderID = patientdet.GenderID.ToString();
                objP.DOB = patientdet.DOB.ToString("MM/dd/yyyy").Replace("-", "/");
                objP.CellPhone = (patientdet.CellPhoneNumber == null) ? "" : patientdet.CellPhoneNumber;
                objP.WorkPhoneNumber = (patientdet.WorkPhoneNumber == null) ? "" : patientdet.WorkPhoneNumber;
                objP.PharmcyPhone = (patientdet.PharmacyPhone == null) ? "" : patientdet.PharmacyPhone;
                res.Info = objP;
                return res;
            }

            if (!string.IsNullOrEmpty(patientid))
            {

                var meds = GetPatientMedication(new PatientMedicationQO() { PatientID = new Guid(patientid.Trim()), IsArchivedFL = false, PageIndex = 1, PageSize = 1000 }).ToList();

                meds = meds.Where(x => x.ID != Guid.Empty).ToList();
                res.Status = "1";
                res.Message = "Success";
                List<PatientMedicationDataRest> Medications = new List<PatientMedicationDataRest>();
                res.Medications = meds.Select(x => new PatientMedicationDataRest
                {
                    ID = Convert.ToString(x.ID),
                    MedicationClass = x.MedicationClassName,
                    MedicationClassID = x.MedicationClassID,
                    MedicationDoseID = x.MedicationDoseID,
                    Name = x.Name,
                    Frequency = string.IsNullOrEmpty(x.Frequency) ? "Other" : x.Frequency,
                    Amount = x.Amount,
                    IsMaxDose = x.IsMaxDose,
                    IsTherapy = x.IsTherapy
                }).ToList();
                var drugs = GetMedicationsByClass(Convert.ToInt32(classID)).ToList();
                var classes = GetDLLookUp().GetLookUpValues(new MasterLookUpQO { TableType = LuTableType.LuMedication }).Select(x => new DropdownItems { Name = x.Name, ID = x.ID }).ToList();
                res.Classes = classes;
                res.Frequency = SetFrequency();
                res.Drugs = drugs;
                var patientdet = GetPatientDemographics(new PatientQO() { ID = new Guid(patientid.Trim()) });
                PatientHeaderInfoRest objP = new PatientHeaderInfoRest();
                objP.City = (patientdet.Address.City == null) ? "" : patientdet.Address.City;
                objP.Address = (patientdet.Address.Street1 == null) ? "" : patientdet.Address.Street1;
                objP.Zip = (patientdet.Address.Zip.ToString() == null) ? "" : patientdet.Address.Zip.ToString();
                string statename = ((StateType)patientdet.Address.StateID).ToString();
                objP.State = (statename == null) ? "" : statename;
                objP.Age = patientdet.PatientAge.ToString();
                objP.GenderID = patientdet.GenderID.ToString();
                objP.DOB = patientdet.DOB.ToString("MM/dd/yyyy").Replace("-", "/");
                objP.CellPhone = (patientdet.CellPhoneNumber == null) ? "" : patientdet.CellPhoneNumber;
                objP.WorkPhoneNumber = (patientdet.WorkPhoneNumber == null) ? "" : patientdet.WorkPhoneNumber;
                objP.PharmcyPhone = (patientdet.PharmacyPhone == null) ? "" : patientdet.PharmacyPhone;
                res.Info = objP;
                return res;
            }
            else
            {
                res.Status = "0";
                res.Message = "id is empty";
                List<PatientMedicationDataRest> Medications = new List<PatientMedicationDataRest>();
                res.Medications = Medications;
                List<DropdownItems> classses = new List<DropdownItems>();
                res.Classes = classses;
                List<Medication> drugs = new List<Medication>();
                res.Drugs = drugs;
                List<DropdownItemsRecipient> freq = new List<DropdownItemsRecipient>();
                res.Frequency = freq;
                var patientdet = GetPatientDemographics(new PatientQO() { ID = new Guid(patientid.Trim()) });
                PatientHeaderInfoRest objP = new PatientHeaderInfoRest();
                objP.City = (patientdet.Address.City == null) ? "" : patientdet.Address.City;
                objP.Address = (patientdet.Address.Street1 == null) ? "" : patientdet.Address.Street1;
                objP.Zip = (patientdet.Address.Zip.ToString() == null) ? "" : patientdet.Address.Zip.ToString();
                string statename = ((StateType)patientdet.Address.StateID).ToString();
                objP.State = (statename == null) ? "" : statename;
                objP.Age = patientdet.PatientAge.ToString();
                objP.GenderID = patientdet.GenderID.ToString();
                objP.DOB = patientdet.DOB.ToString("MM/dd/yyyy").Replace("-", "/");
                objP.CellPhone = (patientdet.CellPhoneNumber == null) ? "" : patientdet.CellPhoneNumber;
                objP.WorkPhoneNumber = (patientdet.WorkPhoneNumber == null) ? "" : patientdet.WorkPhoneNumber;
                objP.PharmcyPhone = (patientdet.PharmacyPhone == null) ? "" : patientdet.PharmacyPhone;
                res.Info = objP;
                return res;
            }
        }
        public PatientClassResult MedicationClassDataRest(string PatientID, string ClassID)
        {
            PatientClassResult result = new PatientClassResult();
            try
            {
                result.Status = "1";
                result.Message = "Success";
                var drugs = GetMedicationsByClass(Convert.ToInt32(ClassID)).ToList();
                var classes = GetDLLookUp().GetLookUpValues(new MasterLookUpQO { TableType = LuTableType.LuMedication }).Select(x => new DropdownItems { Name = x.Name, ID = x.ID }).ToList();
                result.Classes = classes;
                result.Frequency = SetFrequency();
                result.Drugs = drugs;
            }
            catch (Exception ex)
            {
                result.Status = "0";
                result.Message = "Failure";
                List<DropdownItems> classses = new List<DropdownItems>();
                result.Classes = classses;
                List<Medication> drugs = new List<Medication>();
                result.Drugs = drugs;
                List<DropdownItemsRecipient> freq = new List<DropdownItemsRecipient>();
                result.Frequency = freq;

            }
            return result;
        }


        public Result SaveMedicationDataRest(PatientMedicationDataRest patientMedication)
        {
            Result result = new Result();
            try
            {
                PatientMedication patientMed = new PatientMedication();
                Guid ID = string.IsNullOrEmpty(patientMedication.ID) ? Guid.Empty : Guid.Parse(patientMedication.ID);
                patientMed.ID = ID;
                patientMed.PatientID = Guid.Parse(patientMedication.PatientID);
                patientMed.MedicationClassID = patientMedication.MedicationClassID;
                if (patientMedication.MedicationDoseID == 0)
                { patientMed.MedicationDoseID = Int32.MinValue; }
                else
                {
                    patientMed.MedicationDoseID = patientMedication.MedicationDoseID;
                }
                patientMed.Name = patientMedication.Name;
                patientMed.Frequency = patientMedication.Frequency;
                patientMed.Amount = patientMedication.Amount;
                patientMed.Comments = patientMedication.Comments;
                patientMed.CreatedBy = Guid.Parse(patientMedication.CreatedBy);
                patientMed.LastUpdatedBy = Guid.Parse(patientMedication.LastUpdatedBy);
                patientMed.IsMaxDose = patientMedication.IsMaxDose;
                patientMed.IsTherapy = patientMedication.IsTherapy;
                SavePatientMedication(patientMed);
                result.Status = "1";
                result.Message = "Success";

            }
            catch (Exception ex)
            {
                result.Status = "0";
                result.Message = "Failure";

            }
            return result;
        }

        public List<DropdownItemsRecipient> SetFrequency()
        {
            List<DropdownItemsRecipient> objlist = new List<DropdownItemsRecipient>();

            objlist.Add(new DropdownItemsRecipient { Name = "Daily", ID = "qd" });
            objlist.Add(new DropdownItemsRecipient { Name = "Twice daily", ID = "bid" });
            objlist.Add(new DropdownItemsRecipient { Name = "Three times daily", ID = "tid" });
            objlist.Add(new DropdownItemsRecipient { Name = "As needed", ID = "prn" });
            objlist.Add(new DropdownItemsRecipient { Name = "Other", ID = "other" });
            return objlist;
        }
        public PatientDoseResult MedicationDoseDataRest(int MedID)
        {
            PatientDoseResult result = new PatientDoseResult();
            try
            {
                result.Status = "1";
                result.Message = "Success";
                var dose = GetDoseByMedication(MedID).ToList();

                result.Dose = dose;
            }
            catch (Exception ex)
            {
                result.Status = "0";
                result.Message = "Failure";

                List<MedicationDose> dose = new List<MedicationDose>();
                result.Dose = dose;

            }
            return result;
        }

        public ExistResult CheckExistorAllergyRest(string PatientID, string classid)
        {
            ExistResult result = new ExistResult();
            try
            {
                PatientMedicationQO qoObj = new PatientMedicationQO();
                qoObj.PatientID = Guid.Parse(PatientID);
                ObservableCollection<PatientMedication> objMedication = new ObservableCollection<PatientMedication>();
                objMedication = CheckPatientMedication(qoObj);
                var lstmedcalssList = objMedication.ToList().Where(x => x.MedicationClassID == Convert.ToInt32(classid)).FirstOrDefault();
                if (lstmedcalssList != null)
                {
                    result.IsExists = "1";
                }
                ObservableCollection<PatientAllergy> lstAllergies = new ObservableCollection<PatientAllergy>();
                lstAllergies = GetPatientAllergy(new PatientQO() { ID = new Guid(PatientID.Trim()) });
                var lstAllergiesList = lstAllergies.ToList().Where(x => x.ClassID == Convert.ToInt32(classid)).FirstOrDefault();
                if (lstAllergiesList != null)
                {
                    result.IsAllergy = "1";
                }
                result.Status = "1";
                result.Message = "Success";

            }
            catch (Exception ex)
            {
                result.Status = "0";
                result.Message = "Failure";
                result.IsAllergy = "";
                result.IsExists = "";

            }
            return result;
        }

        //public ExistResult IsAllergyRest(string PatientID, string ClassID)
        //{
        //    ExistResult result = new ExistResult();
        //    try
        //    {
        //        ObservableCollection<PatientAllergy> lstAllergies = new ObservableCollection<PatientAllergy>();
        //        lstAllergies = GetPatientAllergy(new PatientQO() { ID = new Guid(PatientID.Trim()) });
        //        var lstAllergiesList = lstAllergies.ToList().Where(x => x.ClassID == Convert.ToInt32(ClassID)).FirstOrDefault();
        //        if (lstAllergiesList != null)
        //        {
        //            result.IsData = "1";
        //        }
        //        result.Status = "1";
        //        result.Message = "Success";

        //    }
        //    catch (Exception ex)
        //    {
        //        result.Status = "0";
        //        result.IsData = "";
        //        result.Message = "Failure";


        //    }
        //    return result;
        //}

    }
}
