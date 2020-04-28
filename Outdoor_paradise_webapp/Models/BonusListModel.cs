using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Outdoor_paradise_webapp.Models {
    public class BonusListModel : BonusIndexModel {
        public IPagedList<BonusIndexModel> Bonussen { get; set; }
    }
}
