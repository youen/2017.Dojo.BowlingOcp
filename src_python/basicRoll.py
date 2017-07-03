class BasicRoll(object):

    def match(self, frame):
        return True

    def compute(self, frame, following_frames, final_score):
        return final_score + sum(frame.get_rolls())
