@QLE-11
Feature: Drag and Drop
As a user in the https://demo.guru99.com/test/drag_drop.html web site
I want to be able to drag BANK and SALES into the Account columns and the amounts in orange to the Amount Column on either DEBIT or CREDIT side
So that above these tables I see the different movements I’ve done by dragging and dropping items

    @automated
    Scenario: User want to select my birthday on the given page
        Given the user is on "drag and drop" page
        When the user drags and drop items
        Then the user can see a perfect button appearing