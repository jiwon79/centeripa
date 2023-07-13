using centeripa.Models;

namespace centeripa.Models {
    public class DoctorRepository {
            //////////////////////////////////////////////////////////////////////////////////////////////////// Field
            ////////////////////////////////////////////////////////////////////////////////////////// Private

            #region Field

            /// <summary>
            /// 소스 리스트
            /// </summary>
            private readonly List<DoctorModel> sourceList = new List<DoctorModel>()
            {
                new DoctorModel { name = "CHEN AHN H, L.AC / 중앙 한의원", speciality = "ACUPUNCTURE / 한의과", address = "2140 W OLYMPIC BLVD, STE 200", city = "LOS ANGELES, CA 90006", phone = "(213) 383-3355", fax = "(855) 326-3041" },
                new DoctorModel { name = "CHEN AHN H, L.AC / 중앙 한의원", speciality = "ACUPUNCTURE / 한의과", address = "2140 W OLYMPIC BLVD, STE 200", city = "LOS ANGELES, CA 90006", phone = "(213) 383-3355", fax = "(855) 326-3041" },
                new DoctorModel { name = "CHEN AHN H, L.AC / 중앙 한의원", speciality = "ACUPUNCTURE / 한의과", address = "2140 W OLYMPIC BLVD, STE 200", city = "LOS ANGELES, CA 90006", phone = "(213) 383-3355", fax = "(855) 326-3041" },
                new DoctorModel { name = "CHEN AHN H, L.AC / 중앙 한의원", speciality = "ACUPUNCTURE / 한의과", address = "2140 W OLYMPIC BLVD, STE 200", city = "LOS ANGELES, CA 90006", phone = "(213) 383-3355", fax = "(855) 326-3041" },
            };

            #endregion

            public List<DoctorModel> GetList() {
                return this.sourceList;
            }
        }
}
