using MultipleInheritanceDefaultInterfaceMembers;

var d = new Dragon() { Age = 7 };

// Casting / Smart Casting is the only way to access these members ( default interface methods )
// from the Dragon Type in this scenario.

if (d is IBird bird)
    bird.Fly();

if (d is ILizard lizard)
    lizard.Crawl();