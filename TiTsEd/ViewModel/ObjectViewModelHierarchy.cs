using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace TiTsEd.ViewModel {
    public class ObjectViewModelHierarchy {
        readonly ReadOnlyCollection<ObjectViewModel> _firstGeneration;
        readonly ObjectViewModel _rootObject;

        public ObjectViewModelHierarchy(object rootObject) {
            _rootObject = new ObjectViewModel(rootObject);
            _rootObject.IsExpanded = true;
            _firstGeneration = new ReadOnlyCollection<ObjectViewModel>(new ObjectViewModel[] { _rootObject });
        }

        public ReadOnlyCollection<ObjectViewModel> FirstGeneration {
            get { return _firstGeneration; }
        }
    }
}
