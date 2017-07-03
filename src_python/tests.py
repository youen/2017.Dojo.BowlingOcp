import unittest

from game import Game

class NumbersTest(unittest.TestCase):

    def test_calculate_basic_score(self):
        tests = [
            ("2,2", 4),
            ("1,4", 5),
            ("1,4,1,4,1,4,1,4,0,0,1,4,1,4,1,4,1,4,0,6", 46),
            ("0,1,9,0,0,9,1,4,0,0,1,4,1,4,1,4,1,4,0,6", 50)
        ]

        for rolls, score in tests:
            with self.subTest(rolls = rolls):
                game = Game()
                for roll in rolls.split(','):
                    game.roll(int(roll))
                self.assertEqual(score, game.score()) 
                
 
    # def test_calculate_spare_score(self):
    #     tests = [
    #         ("1,9,6", 16 + 6),
    #         ("1,4,1,9,1,4,1,4,0,0,1,4,1,4,1,4,1,4,0,6", 52),
    #     ]

    #     for rolls, score in tests:
    #         with self.subTest(rolls = rolls):
    #             game = Game()
    #             for roll in rolls.split(','):
    #                 game.roll(int(roll))
    #             self.assertEqual(score, game.score()) 

if __name__ == '__main__':
    unittest.main()