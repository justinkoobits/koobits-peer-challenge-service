using System;
using System.Collections.Generic;

namespace Koobits.PeerChallenge.Domain.Common.Constants
{
    public static class Constants
    {

        public static class CommonMessages
        {
            public const string ER001 = "No Data Found";
            public const string ER002 = "Invalid data send to Retrieve";
            public const string ER003 = "Invalid data send to Create";
            public const string ER004 = "{0} {1} is not found ";
            public const string ER005 = "Invalid username : {0} not found in system";
            public const string ER006 = "Authentication failed :Invalid username & password";
            public const string ERUKN = "UnKnown Error";
            public const string ER007 = "{0}: Invalid Parameter  passed {1}";
            public const string ER008 = "Invalid Inputs:please check if all required fields are passed : {0}";
            public const string ER009 = "{0} already exists with the same name";
            public const string ER010 = "{0} already exists";
            public const string ER011 = "Assignment Failed";
            public const string ER012 = "Invalid User ID to retrieve";
            public const string ER013 = "Something went wrong";
            public const string ER014 = "Assignment successful, but scheduling failed";

            public const string ER015 = "No Curriculum Was found for the user at the selected level";
            public const string ER016 = "Could not get user level";
            public const string ER017 = "Current Request is restricted in the following days {0}";
            public const string ER018 = "This user is not authororized to update child details";
            public const string ER019 = "Access denied, the feature only for B2C user.";
        }

        public class PeerChallengeMessages
        {
            public const string PCM001 = "You have reached peer challenge limit for today. Please come back tomorrow for new challenges";
            public const string PCM002 = "No peer challenge found";
            public const string PCM003 = "No incoming peer challenges found";
            public const string PCM004 = "No Scheme of work found";
            public const string PCM005 = "Questions not found under that challenge id";
            public const string PCM006 = "No submission found for opponent for this challenge id";
            public const string PCM007 = "No random user found";
            public const string PCM008 = "Please don't pass anything in the PCId parameter, if you are the initiator of this peer challenge";
            public const string PCM009 = "You have already submitted this challenge";
            public const string PCM010 = "Scores will be calculated only when challenge is submitted by challenger and opponent both";
            public const string PCM011 = "Submissions cannot be null";
            public const string PCM012 = "Submission won't happen unless all five questions are supplied";
            public const string PCM013 = "Submission already exists for this challenge and user";
            public const string PCM014 = "Period cannot be 0 or negative";
            public const string PCM015 = "Please come back between 06:00 AM and 10:00 PM";
            public const string PCM016 = "No peer challenge history found";
            public const string PCM017 = "Peer challenge initiator id cannot be the same as the opponent id";
        }

        public static class QuestionGenerator
        {
            public const string QGM001 = "Invalid parameters passed";
            public const string QGM002 = "User doesn't exist";
            public const string QGM003 = "Looks like there is no Curriculum assigned";
            public const string QGM004 = "No setting found";
            public const string QGM005 = "Question could not be fetched";
            public const string QGM006 = "Daily challenge Questions were not found";
            public const string QGM007 = "No topics were not found";
        }

        public static class ChangeQuestion
        {
            public const string CQS001 = "Daily Challenge doesn't exist";
            public const string CQS002 = "User doesn't exist";
            public const string CQS003 = "Topic of the question doesn't exist";
            public const string CQS004 = "Question difficulity doesn't exist";
            public const string CQS005 = "Question level doesn't exist";
            public const string CQS006 = "Failed to get new question";
            public const string CQS007 = "Daily challenge question doesn't exists";
            public const string CQS008 = "Maximum 3 times changes have been reached";
            public const string CQS009 = "Question has been answered correctly or skipped";
        }

        public static class StudentPortalMessages
        {
            public const string SPM001 = "No such user exists";
            public const string SPM002 = "No user info found";
            public const string SPM003 = "No reward data found";
            public const string SPM004 = "Invalid parameters passed";
            public const string SPM005 = "This homework is not assigned to the passed userid";
            public const string SPM006 = "This homework is not submitted yet";
            public const string SPM007 = "The homework submission id does not exist";
            public const string SPM008 = "Either there is no submission for this homework submission id or it is not assigned to this user";
            public const string SPM009 = "The homework id does not exist";
            public const string SPM010 = "No questions found under the homework";
            public const string SPM011 = "No tranItem found";
            public const string SPM012 = "Could not update user koko";
            public const string SPM013 = "Either koko credits are already claimed, or you have reached the maximum limit for this month";
            // //SMC messages
            // public const string SPM014 = "No test found";
            // public const string SPM015 = "No questions found under the challenge";
            // public const string SPM016 = "CP Points can only be claimed between Monday to Friday from 06:00 AM to 10:00 PM";
            // public const string SPM017 = "Either CP Points are already claimed or the test is not submitted yet";
            // public const string SPM018 = "Sunday mini challenges can only be attempted on Sundays between 6:00 AM to 10:00 PM";
            public const string SPM019 = "Some questions do not exist from this challenge";
            // //Koko Monster messages
            // public const string SPM020 = "Level Id cannot be less than zero";

            // public const string SPM021 = "Failed to create user skill mastery";
            // public const string SPM022 = "Failed to create user skill progress";
            // public const string SPM023 = "Failed to create skill progress submission";
            // public const string SPM024 = "User Skill Mastery doesn't exist";
            // public const string SPM025 = "User has already completed the skill";
            // public const string SPM026 = "User already completed the skill";
            // public const string SPM027 = "Variation Question doesn't exist";
            // public const string SPM028 = "Question doesn't exist";

            // public const string SPM029 = "Skill Progress Submission doesn't exist";
            // public const string SPM030 = "User Skill Mastery Doesn't exist";

            // public const string SPM031 = "User doesn't exist";
            //public const string SPM032 = "Curriculum Id cannot be less than zero";

            // public const string SPM033 = "Topic Id cannot be less than equal to zero";
            // public const string SPM034 = "This user doesn't have access to the topic";
            // public const string SPM035 = "This user doesn't have access to the curriculum";

            // public const string SPM036 = "User skill progress doesn't exist";
            // public const string SPM037 = "Skill progress submission doesn't exist";
            // public const string SPM038 = "Submission doesn't exist";

            // //StoryMath
            // public const string SPM039 = "You have not unlocked this chapter";
            // public const string SPM040 = "This chapter has not been released yet";
            // public const string SPM041 = "Invalid chapter";
            // public const string SPM042 = "Oops! You don’t have enough KoKo credits to unlock this chapter. This chapter requires {0} KoKo Credits to unlock. You can earn KoKo credits by completing KooBits Homework.";
            // public const string SPM043 = "Sorry, this chapter has not been released yet. Please unlock after {0}!";
            // public const string SPM045 = "There's no Mini Challenge this Sunday. As a new school term starts next week, have a good rest today and get ready for all new challenges next term. All the best!";

            //Daily Challenge Settings
            public const string SPM_DCS_01 = "You do not have enough Challenge Points to unlock this level";
            public const string SPM_DCS_02 = "You do not have enough EXP to unlock this level";

            //Create Daily Challenge
            public const string SPM_CDC_01 = "Unable to create new Daily Challenge";
            public const string SPM_CDC_02 = "Unable to generate new questions";
            public const string SPM_CDC_03 = "Please set a challenge level first, to create Daily Challenge";
            public const string SPM_CDC_04 = "Unable to update Daily Challenge question";

            // //SupeHero Challenge
            // public const string SPM_SHC_01 = "Unable to submit score";
            // public const string SPM_SHC_02 = "Unable to unlock badge";
            // public const string SPM_SHC_03 = "Unable to get score";
            // public const string SPM_SHC_04 = "Unable to get super hero unlocked status";
            // public const string SPM_SHC_05 = "Unable to get last super hero challenge submission datetime";
            // public const string SPM_SHC_06 = "Unable to get super vision image";
            // public const string SPM_SHC_08 = "Unable to insert super hero score, score has already been inserted";

            // //BFF
            // public const string SPM_BFF_01 = "Unable to get user details";
            // public const string SPM_BFF_02 = "Unable to remove the friend";
        }

        // public static class SubmissionMessages
        // {
        //     public const string ERSUB001 = "Invalid Question {0} with Version {1}";
        //     public const string ERSUB002 = "Invalid Verification Code";
        //     public const string ERSUB003 = "OTP denied";
        //     public const string ERSUB004 = "OTP Expired";
        // }

        // public static class CurriculumMessages
        // {
        //     public const string CM001 = "No curriculum found for this feature Id";
        //     public const string CM002 = "No Hardcoded curriculum set";
        // }

    }
}
