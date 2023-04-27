using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitCare.ViewModels;
using ReactiveUI.Maui;

namespace FitCare.Views;

public partial class ExerciseListView : ReactiveContentPage<ExerciseListViewModel>
{
    public ExerciseListView()
    {
        InitializeComponent();
        ViewModel = new ExerciseListViewModel();
    }
}