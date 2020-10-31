# Pathfinder
---

**simple C# app**
- after you choose 2 solid points, program start finding a path based on a simple algorithm
- you have the ability to add block points    
- the program counts how many steps were needed to reach end how much time it took 

**the algorithm**
- I didn't search out for perfect working programs etc., I wanted to create my own thing,
  after you input **start** and **end** points program calculate length between them, and then
  find find a neighbor point which decrease the length the most.
- If we add some **block** points, they're going straight to "block list" so afterward algorithm 
  choose next potential point, the algorithm also check if it isn't on the list, if it is, this point goes to
  temporary field and the algorithm find another closest point
