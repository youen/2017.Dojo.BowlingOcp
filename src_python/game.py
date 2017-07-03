from basicRoll import BasicRoll

class Frame(object):

    def __init__(self) :
        self.__rolls = []

    def roll(self, i):
        self.__rolls.append(i)

    def get_rolls(self): 
        return self.__rolls[:]

    def count(self) :
        return len(self.__rolls)

class Game(object) : 

    def __init__(self):

        self.__finalScore = 0
        self.__rules = [

            BasicRoll()
        ]

        self.__frames = [Frame()]
        


    def roll(self, i):
        self.__frames[-1].roll(i)

        if self.__frames[-1].count() == 2 :
        
            self.__frames.append(Frame())
        

        score = 0
        for frame in self.__frames :
        
            score = [r for r in self.__rules if r.match(frame)][0].compute(frame, self.followingFrames(frame), score)
        
        self.__finalScore = score

    def score(self):
        return self.__finalScore

    def followingFrames(self, frame):

        return []