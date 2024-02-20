@QLE-12
Feature: Date Picker
    As a user in the https://demo.guru99.com/test/ web site
    asa a user want to be able to select my birthday
    So that by clicking a button I can see a message displaying the birthday I selected

    @automated
    Scenario: User want to select my birthday on the given page
        Given the user is on the "date picker" page
        When the user fills the date
        Then the user can validate the data