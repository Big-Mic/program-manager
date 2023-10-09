using ProgramManager.Domain.Entities.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Domain.Entities
{
    public class Application : Entity
    {
        public Application()
        {
            CreateDefaultPersonalInfo();
            CreateDefaultProfileInfo();
            AdditionalQuestions = new();
        }

        public Image CoverImage { get; set; }

        public List<PersonalInformationQuestion> PersonalInformations { get; private set; }

        public List<Question> AdditionalQuestions { get; private set; }

        public List<ProfileQuestion> ProfileQuestions { get; private set; }
      

        internal void UpdatePersonalInformationList( List<PersonalInformationQuestion> personalInformation)
        {
            PersonalInformations ??= new();

            var submittedIdHash = personalInformation.Select(x => x.Id);
            PersonalInformations.RemoveAll(x => !submittedIdHash.Contains(x.Id));
            var existingPersonalInfos = PersonalInformations.ToDictionary(x => x.Id);
            foreach (var personalInfo in personalInformation)
            {
                if (existingPersonalInfos.ContainsKey(personalInfo.Id))
                {
                    var existingPersonalInfo = existingPersonalInfos[personalInfo.Id];
                    existingPersonalInfo.Update(personalInfo);
                }
                else
                {
                    PersonalInformations.Add(personalInfo);
                }
            }
        }
        internal void UpdateProfileQuestionList(List<ProfileQuestion> profileQuestions)
        {
            ProfileQuestions ??= new();

            var submittedIdHash = profileQuestions.Select(x => x.Id);
            ProfileQuestions.RemoveAll(x => !submittedIdHash.Contains(x.Id));
            var existingProfileQuestions = ProfileQuestions.ToDictionary(x => x.Id);
            foreach (var profileQuestion in profileQuestions)
            {
                if (existingProfileQuestions.ContainsKey(profileQuestion.Id))
                {
                    var exisitingQuestion = existingProfileQuestions[profileQuestion.Id];
                    exisitingQuestion.Update(profileQuestion);
                }
                else
                {
                    ProfileQuestions.Add(profileQuestion);
                }
            }
        }
        internal void UpdateAdditionalList(List<Question> questions)
        {
            AdditionalQuestions ??= new();

            var submittedIdHash = questions.Select(x => x.Id);
            AdditionalQuestions.RemoveAll(x => !submittedIdHash.Contains(x.Id));
            var existingAdditionalQuestions = AdditionalQuestions.ToDictionary(x => x.Id);
            foreach (var question in questions)
            {
                if (existingAdditionalQuestions.ContainsKey(question.Id))
                {
                    var existingAdditionalQuestion = existingAdditionalQuestions[question.Id];
                    existingAdditionalQuestion.Update(question);
                }
                else
                {
                    AdditionalQuestions.Add(question);
                }
            }
        }
        private void CreateDefaultPersonalInfo()
        {
            PersonalInformations = new List<PersonalInformationQuestion>
            {
                new PersonalInformationQuestion(1, "First Name"),
                new PersonalInformationQuestion(2, "Last Name"),
                new PersonalInformationQuestion(3, "Email"),
                new PersonalInformationQuestion(4, "Phone (without dial code)"),
                new PersonalInformationQuestion(5, "Nationality"),
                new PersonalInformationQuestion(6, "Current Residency"),
                new PersonalInformationQuestion(7, "Id Number"),
                new PersonalInformationQuestion(8, "Date of birth", Enums.QuestionType.Date),
                new PersonalInformationQuestion(9, "Gender", Enums.QuestionType.DropDown)
            };
        }
        private void CreateDefaultProfileInfo()
        {
            ProfileQuestions = new List<ProfileQuestion>
            {
                new ProfileQuestion(1, "Education"),
                new ProfileQuestion(2, "Experience"),
                new ProfileQuestion(3, "Resume")
            };
        }
    }
}
