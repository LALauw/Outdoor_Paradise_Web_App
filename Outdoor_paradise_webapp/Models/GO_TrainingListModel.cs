using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Outdoor_paradise_webapp.Models {
    public class GO_TrainingListModel : GO_TrainingModel{
        public IPagedList<GO_TrainingModel> Trainingen { get; set; }
    }
}
