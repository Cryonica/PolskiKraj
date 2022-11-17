using PolskiKraj.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PolskiKraj.ViewModels
{
    public class Verb1ViewModel : BaseViewModel
    {
        public ObservableCollection<WordVerb> Items { get; }
        public Verb1ViewModel()
        {
            Title = "1 спряжение";
            Items = new ObservableCollection<WordVerb>();

            
            foreach(var i in CreateVerbs())
            {
                Items.Add(i);
            }
        }
        List<WordVerb> CreateVerbs()
        {
            return new List<WordVerb>
            {
                new WordVerb{Root="PRAC", EndInfinitiv="OWAĆ", End1="uję", End2="ujesz", End3="uje", End4="ujemy", End5="ujecie", End6="ują", Description="(РАБОТАТЬ)"},
                new WordVerb{Root="DA", EndInfinitiv="WAĆ", End1="ję", End2="jesz", End3="je", End4="jemy", End5="jecie", End6="ją", Description="(ДАВАТЬ)"},
                new WordVerb{Root="D", EndInfinitiv="ĄĆ", End1="mę", End2="miesz", End3="mie", End4="miemy", End5="jmiecie", End6="mą", Description="(ТЯНУТЬ)"},
                new WordVerb{Root="CIĄG", EndInfinitiv="NĄĆ", End1="nę", End2="niesz", End3="nie", End4="niemy", End5="niecie", End6="ną", Description="(ДУТЬ)"},
                new WordVerb{Root="P", EndInfinitiv="IĆ", End1="iję", End2="ijesz", End3="ije", End4="ijemy", End5="ijecie", End6="iją", Description="(ПИТЬ)"},
                new WordVerb{Root="M", EndInfinitiv="YĆ", End1="yję", End2="yjesz", End3="yje", End4="yjemy", End5="yjecie", End6="yją", Description="(МЫТЬ)"},
                new WordVerb{Root="BIEL", EndInfinitiv="EĆ", End1="eję", End2="ejesz", End3="eje", End4="ejemy", End5="ejecie", End6="eją", Description="(БЕЛЕТЬ)"},
                new WordVerb{Root="CHC", EndInfinitiv="IEĆ", End1="ę", End2="esz", End3="e", End4="emy", End5="ecie", End6="ą", Description="(ХОТЕТЬ)"}
            };
        }
    }
}
