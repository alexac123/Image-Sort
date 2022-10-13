﻿using ImageSort.ViewModels;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImageSort.WPF.Views.Metadata
{
    /// <summary>
    /// Interaction logic for MetadataView.xaml
    /// </summary>
    public partial class MetadataView : ReactiveUserControl<MetadataViewModel>
    {
        public MetadataView()
        {
            InitializeComponent();

            this.WhenActivated(disposableRegistration =>
            {
                //this.OneWayBind(ViewModel,
                //        vm => vm.Metadata.Metadata,
                //        view => view.Directories.ItemsSource)
                //    .DisposeWith(disposableRegistration);

                ViewModel.WhenAnyValue(x => x.Metadata)
                    .Where(x => x.Type == MetadataResultType.Success)
                    .Select(x => x.Metadata)
                    .Subscribe(x =>
                    {
                        Directories.Items.Clear();
                        foreach (var item in x)
                        {
                            Directories.Items.Add(item);
                        }
                    });
            });
        }
    }
}
