//examples object creation
function exampleObjectCreation() {
    //JSON syntax
    var myBike = {
        bikeId: 1234, 
        producer: "Trek"
    };

    myBike.model = "Monster";

    //properties
    var myBikeWithProperties = {};
    myBikeWithProperties.bikeId = 1235;
    myBikeWithProperties["producer"] = "Trek";
    console.log(myBikeWithProperties.producer);
}

function jqueryAjaxExample() {
    //make a post call
    var url = "http://localhost:8080/test/";
    //
    $.ajax(
            {
                url: url,
                data: data,
                type: 'POST',
                dataType: 'json',
                cache: false,
                success: function (data) {
                    if (data.Status != 'Processed') {
                        //do something
                        return;
                    }

                    //validate data from result
                    if (data.IsNew) {
                        //do something
                    } else {
                        //do something else
                    }
                },
                error: function () {
                   //do something
                }
            }
    );
}

//examples for code style
function exampleObjectRules() {//there is a empty spece before the opening bracket, cammelCase for function names as well
    //indented
    var myVar = undefined;//cammelCase 

    var myBike = {
        bikeId: 1234, //numbers are not initialized as strings, collon + one space between property and value
        producer: "Trek" //string is in quotes, no comma on last property
    }; //newline, noleading spaces, indented, object definition ends with semicolon

    if (myBike == undefined) {
        console.log("The bike is not defined!");
    } //no semicolon at end of statement
}//closing bracket is in new line

//example mistakes
function exampleMistakesReturn() {
    var
        myVar = 10;
    return myVar * 5;//will return 50
}

function exampleMistakesBreakingReturn() {
    var
        myVar = 10;
    return
    myVar * 5;//will return 50 see the comment here
}

function accessingArrays() {
    var person = [];
    person[0] = "John";
    person[1] = "Doe";
    person[2] = 46;
    var x = person.length;         // person.length will return 3
    var y = person[0];             // person[0] will return "John"
    //but
    var person1 = [];
    person1["firstName"] = "John";   //defines a new property on object person .firstName
    person1["lastName"] = "Doe";
    person1["age"] = 46;
    var x1 = person1.length;         // person.length will return 0
    var y1= person1[0];             // person[0] will return undefined
}