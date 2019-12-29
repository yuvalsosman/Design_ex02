using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static FacebookWrapper.ObjectModel.User;

namespace FormsUI.FacebookAppLogic
{
    public static class FilterFriendsLogic
    {
        public static List<User> FilterFriendLists(List<User> i_FriendList, CheckBox i_MaleCheckBox, CheckBox i_FemaleCheckBox, CheckBox i_SingleStatusCheckBox, CheckBox i_RelationshipStatusCheckBox, CheckBox i_ComplicatedStatusCheckBox)
        {
            List<User> filteredFriendList = new List<User>();
            if (i_FriendList.Count > 0)
            {
                foreach (User friend in i_FriendList)
                {
                    if (isFriendMatchRequirements(friend, i_MaleCheckBox, i_FemaleCheckBox, i_SingleStatusCheckBox, i_RelationshipStatusCheckBox, i_ComplicatedStatusCheckBox))
                    {
                        filteredFriendList.Add(friend);
                        friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                    }
                }
            }

            return filteredFriendList;
        }

        private static Boolean isFriendMatchRequirements(User i_Friend, CheckBox i_MaleCheckBox, CheckBox i_FemaleCheckBox, CheckBox i_SingleStatusCheckBox, CheckBox i_RelationshipStatusCheckBox, CheckBox i_ComplicatedStatusCheckBox)
        {
            bool relationshipStatusBoolean = false;
            bool genderBoolean = false;

            List<eGender> genders = new List<eGender>();
            if (i_MaleCheckBox.Checked)
            {
                genders.Add(eGender.male);
            }
            if (i_FemaleCheckBox.Checked)
            {
                genders.Add(eGender.female);
            }
            if (genders.Count == 0)
            {
                genderBoolean = true;
            }
            else
            {
                foreach (eGender gender in genders)
                {
                    if (gender == i_Friend.Gender)
                    {
                        genderBoolean = true;
                    }
                }
            }

            List<eRelationshipStatus> relationshipStatuses = new List<eRelationshipStatus>();
            if (i_SingleStatusCheckBox.Checked)
            {
                relationshipStatuses.Add(eRelationshipStatus.Single);
            }
            if (i_RelationshipStatusCheckBox.Checked)
            {
                relationshipStatuses.Add(eRelationshipStatus.InARelationship);
            }
            if (i_ComplicatedStatusCheckBox.Checked)
            {
                relationshipStatuses.Add(eRelationshipStatus.ItsComplicated);
            }
            if (relationshipStatuses.Count == 0)
            {
                relationshipStatusBoolean = true;
            }
            else
            {
                foreach (eRelationshipStatus relationshipStatus in relationshipStatuses)
                {
                    if (relationshipStatus == i_Friend.RelationshipStatus)
                    {
                        relationshipStatusBoolean = true;
                    }
                }
            }

            return (genderBoolean && relationshipStatusBoolean);
        }
    }
}
