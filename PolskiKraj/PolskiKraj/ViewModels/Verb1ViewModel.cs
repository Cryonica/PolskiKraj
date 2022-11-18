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
                new WordVerb(1){Root1="PRAC", Root2= "PRAC", EndInfinitiv="OWAĆ", Description="PRACOWAĆ (РАБОТАТЬ)", Letter1= "uj", Letter2="e"},
                new WordVerb(1){Root1="DA", Root2= "DA", EndInfinitiv="WAĆ", Description="DAWAĆ (ДАВАТЬ)", Letter1= "j", Letter2="e"},
                new WordVerb(1){Root1="CIĄGN", Root2="CIĄGNI", EndInfinitiv="ĄĆ", Letter1="", Letter2="e", Description="CIĄGNĄĆ (ТЯНУТЬ)"},
                new WordVerb(1){Root1="BIOR", Root2="BIERZ", EndInfinitiv="AĆ", Letter1="", Letter2="e", Description="CIĄGNĄĆ (ТЯНУТЬ)"},
                new WordVerb(1){Root1="DM", Root2="DMI", EndInfinitiv="NĄĆ", Letter1="", Letter2="e", Description="DĄĆ (ДУТЬ)"},
                new WordVerb(1){Root1="PI", Root2="PI", EndInfinitiv="IĆ", Letter1="j", Letter2="e", Description="PIĆ (ПИТЬ)"},
                new WordVerb(1){Root1="MY", Root2="MY", EndInfinitiv="YĆ", Letter1="j", Letter2="e", Description="MYĆ (МЫТЬ)"},
                new WordVerb(1){Root1="BIELE", Root2="BIELE", EndInfinitiv="EĆ", Letter1="j", Letter2="e", Description="BIELEĆ (БЕЛЕТЬ)"},
                new WordVerb(1){Root1="CHC", Root2="CHC", EndInfinitiv="IEĆ", Letter1="", Letter2="e", Description="CHCIEĆ (ХОТЕТЬ)"},

            };
        }
    }
}
