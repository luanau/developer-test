# CANDIDATE README
I created this file to explain what I do with the tasks given.

## Setting up

Fork repo
Create a new branch (interview-tasks) to do the tasks in.
Open solution in VS2015
Restore Nuget packages 
Update-Database to rebuild the Database. 
Slight issue encountered while updating the database so I had to update the connection string,

## Familiarisation with the application
Run the app to check it out and familiarise myself with it.
Create buyer and a seller users to test and learn existing functionality.

## Tests suggestions 
Tests:
  - I can register a buyer
  - I can register a seller
  - As a seller I can list a property
  - As a buyer I should be notified if my offer has been accepted by the seller

## Possible enhanements

Buyer cannot see that they have already made an offer on a property!
The "Make Offer" button should be disabled and grayed out when being viewed by the buyer that has already made an offer on it.


## Queries
Can a buyer make offers on multiple properties? If so more than one offers may be accepted leading to the situation where the buyer have to then reject acceptances from some sellers. This is not ideal. So should we restrict buyer to having a single live offer?

## Objective 1 Implementation
*User Story: As a buyer I want to see when my offer has been accepted so that I can proceed with the property purchase.*

For this objective I will display a prominent notification on the buyer's home page when she logs in to inform her of the good news when her offer on a property has been accepted. This will be in the form of a red div with white text.

We need to identify the buyer who made an offer on a property. We'll add a new property, **BuyerUserId**, to the Offer model just as we already have the SellerUserId in the Property model.

### Add a migration to update the database model
Create a new migration to add the new property BuyerUserId
    Add-Migration AddBuyerUserIdToOffer
    Update-Database
