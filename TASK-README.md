# README for Developer Test Tasks 

Create a new branch (interview-tasks) to do the tasks in.
Restore Nuget packages 
Update-Database to rebuild the Database. 
Slight issue encountered while updating the database so I had to update the connection string,

**Familiarisation with the application**
Run the app to check it out and familiarise myself with it.
Create buyer and a seller users to test and learn existing functionality.

**POSSIBLE TESTS CASES**
Tests: I can add a buyer; I can add a seller; I can list a property.
  - I can register a buyer
  - I can register a seller
  - As a seller I can list a property

**ISSUES**
Seller cannot see offers placed on their properties!
Buyer cannot see that they have already made an offer on a property!
The "Make Offer" button should be disabled and grayed out when being viewed 
by the buyer that has already made an offer on it.

Some issues with registering users. They don't seem to be added dynamically 
but only at the end

**Queries**
Can a buyer make offers on multiple properties? 
More than one offers may be accepted leading to the situation where the buyer have to then reject acceptances from sellers.
Not a good situation. So should we restrict buyer to having a single live offer?

User Story: As a buyer I want to see when my offer has been accepted so that I can proceed with the property purchase.

This means we need to identify offers made by a particular buyer. Who made the offer? A buyer? Which buyer? So we need
a BuyerUserId property for the Offer model just as we need the SellerUserId in the Property model.

Create a new migration to add the new property BuyerUserId
    Add-Migration AddBuyerUserIdToOffer
    Update-Database
