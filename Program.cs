using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
         List<Promoter> promoters = new List<Promoter>(){new XSClubPromoter("Silumi", "Kaundika", 0714774883),
         new XSClubPromoter("Thilaka", "Pathirana", 0718048181),
         new OmniaClubPromoter("Gangani", "Gamage", 0718774883)};

         foreach (var promoter in promoters){
             promoter.Promote();
         }

         List<Writer> writers = new List<Writer> (){new BookWriter("Silumi", "Kaundika"),new BookWriter("Silu", "Kaundi"),
         new BlogWriter("Gangani", "Gamage")};

          foreach (var writer in writers){
             writer.Write();
         }


         List<IBodyBuilder> bodyBuilders = new List<IBodyBuilder> (){new XSClubPromoter("Silumi", "Kaundika", 0715555588),
         new XSClubPromoter("Silu", "Kaundi",071234234)
        };

        foreach (var bodyBuilder in bodyBuilders){
             bodyBuilder.workout();
         }

        List<IVlogger> loggers = new List<IVlogger> (){new BookWriter("Silumi", "Kaundika"),
         new BlogWriter("Silu", "Kaundi")
        };

         foreach (var logger in loggers){
             logger.vlog();
         }

        }
    }
}
