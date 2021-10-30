using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriMadenciligi.Excel.ExcelModel;

namespace VeriMadenciligi.Step3
{
    public class HowManyDiffrentItem
    {
        public List<List<List<int>>> Calculate(List<ExcelData> veriler)
        {
            List<int> inGenderF = new List<int>() { 0, 0, 0 };
            List<int> inGenderM = new List<int>() { 0, 0, 0 };

            List<int> inNationalityLebanon = new List<int>() { 0, 0, 0 };
            List<int> inNationalityJordan = new List<int>() { 0, 0, 0 };
            List<int> inNationalityIraq = new List<int>() { 0, 0, 0 };
            List<int> inNationalityPalestine = new List<int>() { 0, 0, 0 };
            List<int> inNationalityKW = new List<int>() { 0, 0, 0 };

            List<int> inPlaceOfBirthUSA = new List<int>() { 0, 0, 0 };
            List<int> inPlaceOfBirthJordan = new List<int>() { 0, 0, 0 };
            List<int> inPlaceOfBirthIraq = new List<int>() { 0, 0, 0 };
            List<int> inPlaceOfBirthlebanon = new List<int>() { 0, 0, 0 };
            List<int> inPlaceOfBirthKuwaIT = new List<int>() { 0, 0, 0 };

            List<int> inStageIDHighSchool = new List<int>() { 0, 0, 0 };
            List<int> inStageIDMiddleSchool = new List<int>() { 0, 0, 0 };
            List<int> inStageIDLowerLevel = new List<int>() { 0, 0, 0 };

            List<int> inSectionIdA = new List<int>() { 0, 0, 0 };
            List<int> inSectionIdB = new List<int>() { 0, 0, 0 };
            List<int> inSectionIdC = new List<int>() { 0, 0, 0 };

            List<int> inTopicIdIT = new List<int>() { 0, 0, 0, };
            List<int> inTopicIdFrench = new List<int>() { 0, 0, 0, };
            List<int> inTopicIdArabic = new List<int>() { 0, 0, 0, };
            List<int> inTopicIdEnglish = new List<int>() { 0, 0, 0, };
            List<int> inTopicIdScience = new List<int>() { 0, 0, 0, };
            List<int> inTopicIdBiology = new List<int>() { 0, 0, 0, };
            List<int> inTopicIdChemistry = new List<int>() { 0, 0, 0, };
            List<int> inTopicIdSpanish = new List<int>() { 0, 0, 0, };
            List<int> inTopicIdMath = new List<int>() { 0, 0, 0, };
            List<int> inTopicIdGeology = new List<int>() { 0, 0, 0, };
            List<int> inTopicIdHistory = new List<int>() { 0, 0, 0, };
            List<int> inTopicIdQuran = new List<int>() { 0, 0, 0, };

            List<int> inSemesterF = new List<int>() { 0, 0, 0 };
            List<int> inSemesterS = new List<int>() { 0, 0, 0 };

            List<int> inRelationMum = new List<int>() { 0, 0, 0 };
            List<int> inRelationFather = new List<int>() { 0, 0, 0 };

            List<int> inParentAnsYes = new List<int>() { 0, 0, 0 };
            List<int> inParentAnsNo = new List<int>() { 0, 0, 0 };

            List<int> inParentSchGood = new List<int>() { 0, 0, 0 };
            List<int> inParentSchBad = new List<int>() { 0, 0, 0 };

            List<int> inStudentUnder7 = new List<int>() { 0, 0, 0 };
            List<int> inStudentAbove7 = new List<int>() { 0, 0, 0 };

            List<int> inClass = new List<int>() { 0, 0, 0 };


            List<List<int>> genderEntropi = new List<List<int>>() { inGenderF, inGenderM };
            List<List<int>> nationalityEntropi = new List<List<int>>() { inNationalityLebanon, inNationalityJordan, inNationalityIraq, inNationalityPalestine, inNationalityKW };
            List<List<int>> placeOfBirthEntropi = new List<List<int>>() { inPlaceOfBirthUSA, inPlaceOfBirthJordan, inPlaceOfBirthIraq, inPlaceOfBirthlebanon, inPlaceOfBirthKuwaIT };
            List<List<int>> stageIdEntropi = new List<List<int>>() { inStageIDHighSchool, inStageIDMiddleSchool, inStageIDLowerLevel };
            List<List<int>> SectionIdEntropi = new List<List<int>>() { inSectionIdA, inSectionIdB, inSectionIdC };
            List<List<int>> topicEntropi = new List<List<int>>() { inTopicIdIT, inTopicIdFrench, inTopicIdArabic, inTopicIdEnglish, inTopicIdScience, inTopicIdBiology, inTopicIdChemistry, inTopicIdSpanish, inTopicIdMath, inTopicIdGeology, inTopicIdHistory, inTopicIdQuran };
            List<List<int>> semesterEntropi = new List<List<int>>() { inSemesterF, inSemesterS };
            List<List<int>> relationEntropi = new List<List<int>>() { inRelationMum, inRelationFather };
            List<List<int>> ParentAnsweringSurveyEntropi = new List<List<int>>() { inParentAnsYes, inParentAnsNo };
            List<List<int>> ParentschoolSatisfactionEntropi = new List<List<int>>() { inParentSchGood, inParentSchBad };
            List<List<int>> StudentAbsenceDaysEntropi = new List<List<int>>() { inStudentUnder7, inStudentAbove7 };
            List<List<int>> classEntropi = new List<List<int>>() { inClass };

            List<List<List<int>>> ListVeriler = new List<List<List<int>>>() {genderEntropi, nationalityEntropi, placeOfBirthEntropi, stageIdEntropi,
                SectionIdEntropi, topicEntropi, semesterEntropi, relationEntropi, ParentAnsweringSurveyEntropi,
            ParentschoolSatisfactionEntropi, StudentAbsenceDaysEntropi, classEntropi};

            for (int i = 0; i < veriler.Count; i++)
            {
                if (veriler[i].gender == "F")
                {
                    if (veriler[i].Class == "M")
                        inGenderF[0]++;
                    else if (veriler[i].Class == "L")
                        inGenderF[1]++;
                    else
                        inGenderF[2]++;
                }
                else
                {
                    if (veriler[i].Class == "M")
                        inGenderM[0]++;
                    else if (veriler[i].Class == "L")
                        inGenderM[1]++;
                    else
                        inGenderM[2]++;
                }


                if (veriler[i].NationalITy == "lebanon")
                {
                    {
                        if (veriler[i].Class == "M")
                            inNationalityLebanon[0]++;
                        else if (veriler[i].Class == "L")
                            inNationalityLebanon[1]++;
                        else
                            inNationalityLebanon[2]++;
                    }
                }
                else if (veriler[i].NationalITy == "Jordan")
                {
                    if (veriler[i].Class == "M")
                        inNationalityJordan[0]++;
                    else if (veriler[i].Class == "L")
                        inNationalityJordan[1]++;
                    else
                        inNationalityJordan[2]++;
                }
                else if (veriler[i].NationalITy == "Iraq")
                {
                    if (veriler[i].Class == "M")
                        inNationalityIraq[0]++;
                    else if (veriler[i].Class == "L")
                        inNationalityIraq[1]++;
                    else
                        inNationalityIraq[2]++;
                }
                else if (veriler[i].NationalITy == "Palestine")
                {
                    if (veriler[i].Class == "M")
                        inNationalityPalestine[0]++;
                    else if (veriler[i].Class == "L")
                        inNationalityPalestine[1]++;
                    else
                        inNationalityPalestine[2]++;
                }
                else
                {
                    if (veriler[i].Class == "M")
                        inNationalityKW[0]++;
                    else if (veriler[i].Class == "L")
                        inNationalityKW[1]++;
                    else
                        inNationalityKW[2]++;
                }


                if (veriler[i].PlaceofBirth == "USA")
                {
                    if (veriler[i].Class == "M")
                        inPlaceOfBirthUSA[0]++;
                    else if (veriler[i].Class == "L")
                        inPlaceOfBirthUSA[1]++;
                    else
                        inPlaceOfBirthUSA[2]++;
                }
                else if (veriler[i].PlaceofBirth == "Jordan")
                {
                    if (veriler[i].Class == "M")
                        inPlaceOfBirthJordan[0]++;
                    else if (veriler[i].Class == "L")
                        inPlaceOfBirthJordan[1]++;
                    else
                        inPlaceOfBirthJordan[2]++;
                }
                else if (veriler[i].PlaceofBirth == "Iraq")
                {
                    if (veriler[i].Class == "M")
                        inPlaceOfBirthIraq[0]++;
                    else if (veriler[i].Class == "L")
                        inPlaceOfBirthIraq[1]++;
                    else
                        inPlaceOfBirthIraq[2]++;
                }
                else if (veriler[i].PlaceofBirth == "lebanon")
                {
                    if (veriler[i].Class == "M")
                        inPlaceOfBirthlebanon[0]++;
                    else if (veriler[i].Class == "L")
                        inPlaceOfBirthlebanon[1]++;
                    else
                        inPlaceOfBirthlebanon[2]++;
                }
                else
                {
                    if (veriler[i].Class == "M")
                        inPlaceOfBirthKuwaIT[0]++;
                    else if (veriler[i].Class == "L")
                        inPlaceOfBirthKuwaIT[1]++;
                    else
                        inPlaceOfBirthKuwaIT[2]++;
                }


                if (veriler[i].StageID == "HighSchool")
                {
                    if (veriler[i].Class == "M")
                        inStageIDHighSchool[0]++;
                    else if (veriler[i].Class == "L")
                        inStageIDHighSchool[1]++;
                    else
                        inStageIDHighSchool[2]++;
                }
                else if (veriler[i].StageID == "MiddleSchool")
                {
                    if (veriler[i].Class == "M")
                        inStageIDMiddleSchool[0]++;
                    else if (veriler[i].Class == "L")
                        inStageIDMiddleSchool[1]++;
                    else
                        inStageIDMiddleSchool[2]++;
                }
                else
                {
                    if (veriler[i].Class == "M")
                        inStageIDLowerLevel[0]++;
                    else if (veriler[i].Class == "L")
                        inStageIDLowerLevel[1]++;
                    else
                        inStageIDLowerLevel[2]++;
                }



                if (veriler[i].SectionID == "A")
                {
                    if (veriler[i].Class == "M")
                        inSectionIdA[0]++;
                    else if (veriler[i].Class == "L")
                        inSectionIdA[1]++;
                    else
                        inSectionIdA[2]++;
                }
                else if (veriler[i].SectionID == "B")
                {
                    if (veriler[i].Class == "M")
                        inSectionIdB[0]++;
                    else if (veriler[i].Class == "L")
                        inSectionIdB[1]++;
                    else
                        inSectionIdB[2]++;
                }
                else
                {
                    if (veriler[i].Class == "M")
                        inSectionIdC[0]++;
                    else if (veriler[i].Class == "L")
                        inSectionIdC[1]++;
                    else
                        inSectionIdC[2]++;
                }


                if (veriler[i].Topic == "IT")
                {
                    if (veriler[i].Class == "M")
                        inTopicIdIT[0]++;
                    else if (veriler[i].Class == "L")
                        inTopicIdIT[1]++;
                    else
                        inTopicIdIT[2]++;
                }
                else if (veriler[i].Topic == "French")
                {
                    if (veriler[i].Class == "M")
                        inTopicIdFrench[0]++;
                    else if (veriler[i].Class == "L")
                        inTopicIdFrench[1]++;
                    else
                        inTopicIdFrench[2]++;
                }
                else if (veriler[i].Topic == "Arabic")
                {
                    if (veriler[i].Class == "M")
                        inTopicIdArabic[0]++;
                    else if (veriler[i].Class == "L")
                        inTopicIdArabic[1]++;
                    else
                        inTopicIdArabic[2]++;
                }
                else if (veriler[i].Topic == "English")
                {
                    if (veriler[i].Class == "M")
                        inTopicIdEnglish[0]++;
                    else if (veriler[i].Class == "L")
                        inTopicIdEnglish[1]++;
                    else
                        inTopicIdEnglish[2]++;
                }
                else if (veriler[i].Topic == "Science")
                {
                    if (veriler[i].Class == "M")
                        inTopicIdScience[0]++;
                    else if (veriler[i].Class == "L")
                        inTopicIdScience[1]++;
                    else
                        inTopicIdScience[2]++;
                }
                else if (veriler[i].Topic == "Biology")
                {
                    if (veriler[i].Class == "M")
                        inTopicIdBiology[0]++;
                    else if (veriler[i].Class == "L")
                        inTopicIdBiology[1]++;
                    else
                        inTopicIdBiology[2]++;
                }
                else if (veriler[i].Topic == "Chemistry")
                {
                    if (veriler[i].Class == "M")
                        inTopicIdChemistry[0]++;
                    else if (veriler[i].Class == "L")
                        inTopicIdChemistry[1]++;
                    else
                        inTopicIdChemistry[2]++;
                }
                else if (veriler[i].Topic == "Spanish")
                {
                    if (veriler[i].Class == "M")
                        inTopicIdSpanish[0]++;
                    else if (veriler[i].Class == "L")
                        inTopicIdSpanish[1]++;
                    else
                        inTopicIdSpanish[2]++;
                }
                else if (veriler[i].Topic == "Math")
                {
                    if (veriler[i].Class == "M")
                        inTopicIdMath[0]++;
                    else if (veriler[i].Class == "L")
                        inTopicIdMath[1]++;
                    else
                        inTopicIdMath[2]++;
                }
                else if (veriler[i].Topic == "Geology")
                {
                    if (veriler[i].Class == "M")
                        inTopicIdGeology[0]++;
                    else if (veriler[i].Class == "L")
                        inTopicIdGeology[1]++;
                    else
                        inTopicIdGeology[2]++;
                }
                else if (veriler[i].Topic == "History")
                {
                    if (veriler[i].Class == "M")
                        inTopicIdHistory[0]++;
                    else if (veriler[i].Class == "L")
                        inTopicIdHistory[1]++;
                    else
                        inTopicIdHistory[2]++;
                }
                else
                {
                    if (veriler[i].Class == "M")
                        inTopicIdQuran[0]++;
                    else if (veriler[i].Class == "L")
                        inTopicIdQuran[1]++;
                    else
                        inTopicIdQuran[2]++;
                }


                if (veriler[i].Semester == "F")
                {
                    if (veriler[i].Class == "M")
                        inSemesterF[0]++;
                    else if (veriler[i].Class == "L")
                        inSemesterF[1]++;
                    else
                        inSemesterF[2]++;
                }
                else
                {
                    if (veriler[i].Class == "M")
                        inSemesterS[0]++;
                    else if (veriler[i].Class == "L")
                        inSemesterS[1]++;
                    else
                        inSemesterS[2]++;
                }


                if (veriler[i].Relation == "Mum")
                {
                    if (veriler[i].Class == "M")
                        inRelationMum[0]++;
                    else if (veriler[i].Class == "L")
                        inRelationMum[1]++;
                    else
                        inRelationMum[2]++;
                }
                else
                {
                    if (veriler[i].Class == "M")
                        inRelationFather[0]++;
                    else if (veriler[i].Class == "L")
                        inRelationFather[1]++;
                    else
                        inRelationFather[2]++;
                }


                if (veriler[i].ParentAnsweringSurvey == "Yes")
                {
                    if (veriler[i].Class == "M")
                        inParentAnsYes[0]++;
                    else if (veriler[i].Class == "L")
                        inParentAnsYes[1]++;
                    else
                        inParentAnsYes[2]++;
                }
                else
                {
                    if (veriler[i].Class == "M")
                        inParentAnsNo[0]++;
                    else if (veriler[i].Class == "L")
                        inParentAnsNo[1]++;
                    else
                        inParentAnsNo[2]++;
                }


                if (veriler[i].ParentschoolSatisfaction == "Good")
                {
                    if (veriler[i].Class == "M")
                        inParentSchGood[0]++;
                    else if (veriler[i].Class == "L")
                        inParentSchGood[1]++;
                    else
                        inParentSchGood[2]++;
                }
                else
                {
                    if (veriler[i].Class == "M")
                        inParentSchBad[0]++;
                    else if (veriler[i].Class == "L")
                        inParentSchBad[1]++;
                    else
                        inParentSchBad[2]++;
                }


                if (veriler[i].StudentAbsenceDays == "Under-7")
                {
                    if (veriler[i].Class == "M")
                        inStudentUnder7[0]++;
                    else if (veriler[i].Class == "L")
                        inStudentUnder7[1]++;
                    else
                        inStudentUnder7[2]++;
                }
                else
                {
                    if (veriler[i].Class == "M")
                        inStudentAbove7[0]++;
                    else if (veriler[i].Class == "L")
                        inStudentAbove7[1]++;
                    else
                        inStudentAbove7[2]++;
                }


                if (veriler[i].Class == "M")
                    inClass[0]++;
                else if (veriler[i].Class == "L")
                    inClass[1]++;
                else
                    inClass[2]++;
            }

            return ListVeriler;
        }
    }
}
