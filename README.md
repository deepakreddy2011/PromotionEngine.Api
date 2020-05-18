# Promotion Engine
Promotion Engine which returns cart total after successful application of promotions
Clean/Onion architecture is followed for api implementaion
Domain models and Promotion interfaces are kept inside 'Core'
Developed Api using TDD approach using Red,Green and Refactor methodolgy. changes can be seen in repository commits
Modularity of the Project has been maintained for example : In order to add new promotion all we need to do is to create new implementaion for IPromotion in Infrasturcture and implement Apply() method.

Note: i observed a contradictory statement in the assignment.statement says promotions are mutually exclusive but up on seeing test cases looks like all the promotions can be applied at the same time. so my developmet direction is same as per test cases
          
