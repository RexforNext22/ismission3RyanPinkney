// Ryan Pinkney
// This is the javascript that will be the grade calculator. It takes the percentage from the HTML form
// and determines the letter grade. The page uses jquery

// Create the function that will run when the button is pushed
$("#cal").click(function () {

    // Collect the input values
    fPercent = parseInt($("#percent").val())

    //Initalize the output varaible
    sLetterGrade = ""


    // This if statement will determine the letter grade for the percentage
    if (fPercent >= 93) {
        sLetterGrade = "A"
    } else if (fPercent >= 90) {
        sLetterGrade = "A-"
    } else if (fPercent >= 87) {
        sLetterGrade = "B+"
    } else if (fPercent >= 83) {
        sLetterGrade = "B"
    } else if (fPercent >= 80) {
        sLetterGrade = "B-"
    } else if (fPercent >= 77) {
        sLetterGrade = "C+"
    } else if (fPercent >= 73) {
        sLetterGrade = "C"
    } else if (fPercent >= 70) {
        sLetterGrade = "C-"
    } else if (fPercent >= 67) {
        sLetterGrade = "D+"
    } else if (fPercent >= 63) {
        sLetterGrade = "D"
    } else if (fPercent >= 60) {
        sLetterGrade = "D-"
    } else {
        sLetterGrade = "E"
    }

    // Alert the output to the user concated witha message.
    alert("Your scored a(n) " + fPercent + "% and your letter grade is a(n) " + sLetterGrade + ".")
})