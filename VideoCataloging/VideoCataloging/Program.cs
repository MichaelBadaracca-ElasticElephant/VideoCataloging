using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCataloging
{
    class Program
    {
        static void Main(string[] args)
        {

            //CreateFoldersFromSpreadsheet
            //CreateLabelsFromSpreadsheet
            //CreatesLabelesFromFolder
            //CreateSpreadsheetFromFolder
            //RipIsoFromDisc
            //ConvertIsoToMp4
            //GetVideoLength
            //GetVideoNameFromDvd


            //VideoMetadata
                //VideoId
                //WrittenName
                //RefinedName
                //Length
                //Author
                //Organization
                //PeopleInvolved (list)
                //Comments
                //SeriesLength (int)
                //SeriesNum
                //VhsPicture (path)
                //VhsRecordingQuality (enum)
                
            
            //Conversion State
                //ConvertedVhsToDvd
                //ConvertedDvdToIso
                //ConvertedIsoToMp4
                //DvdMatchedWithVhs
                //UniqueLabelCreated
                //VhsLabeled
                //DvdLabeled
               
            //Resources
                //ffmpeg
                //handbrake
                //opensource spreadsheet dll
                //something to convert dvd to iso

            //Desired Operation
                //Digitize Video
                    //Start app
                    //Give command to put dvds on computer
                    //DVD to computer flow
                        //Ask for top directory for DVD (use filepicker)
                        //Ask for name of DVD
                            //Save to database (either excel spreasheet or actual database)
                        //Open DVD Drive
                        //once DVD has been inserted
                            //Create Folder in top directory with DVD Name
                            //Begin creating ISO with librarys
                                    //High Quality
                                    //Get rid of interlacing
                        //Once dvd is finished give a message saying complete (and sound maybe)
                        //Repeat prompt for next dvd name
                    //Have the ability to exit to main menu
    
                //Batch convert to mp4
                //
                
        }
    }
}
