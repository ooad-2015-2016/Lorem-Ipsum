using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MashComputerShop.MashShop.Models
{
    public class ConfigurationOption
    {
        public string OptionImagePath { get; set; }
        public string OptionTitle { get; set; }
        
        public ConfigurationOption(string OptionTitle, string OptionImagePath)
        {
            this.OptionTitle = OptionTitle;
            this.OptionImagePath = OptionImagePath;
        }
    }


    public class OptionsCatalog
    {
        // Opcije koje se prikazuju za odabir ranga cijene prilikom kreiranja konfiguracije
        public static List<ConfigurationOption> getConfigurationOptions()
        {
            return new List<ConfigurationOption>
            {
                new ConfigurationOption("Pristupačnija Cijena", "ms-appx:///Assets/Icons/walleticon.png"),
                new ConfigurationOption("Bolje Performanse", "ms-appx:///Assets/Icons/performanceicon.png"),
                new ConfigurationOption("Balans Cijene i Performansi", "ms-appx:///Assets/Icons/balanceicon.png"),
                new ConfigurationOption("Maksimalne Performanse", "ms-appx:///Assets/Icons/performanceicon.png")
            };
        }


        // Opcije koje se pokazuju za odabir komponenti prilikom kreiranja konfiguracije
        public static List<ConfigurationOption> getComponentOptions()
        {
            return new List<ConfigurationOption>
            {
                new ConfigurationOption("Matična Ploča", "ms-appx:///Assets/Icons/motherboardicon.png"),
                new ConfigurationOption("Magnetni Disk", "ms-appx:///Assets/Icons/hddicon.png"),
                new ConfigurationOption("Solid State Drive", "ms-appx:///Assets/Icons/ssdicon.png"),
                new ConfigurationOption("Procesor", "ms-appx:///Assets/Icons/processoricon.png"),
                new ConfigurationOption("RAM", "ms-appx:///Assets/Icons/ramicon.png"),
                new ConfigurationOption("GPU", "ms-appx:///Assets/Icons/gpuicon.png"),
                new ConfigurationOption("Zvučna Karta", "ms-appx:///Assets/Icons/soundcardicon.png"),
                new ConfigurationOption("Dodatno", "ms-appx:///Assets/Icons/extraicon.png")
            };
        }
    }
}
