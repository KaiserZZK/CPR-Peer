#CPeeR
##Inspiration
After exploring many exciting uses of MRTK, we feel that with its ability to merge the physical and virtual world, it would be especially useful for CPR training, by helping people connecting what is going on inside a human's body and the physical action of compressing.

##What it does
Built using MRTK3 and ran on Oculus Quest 2, CPeeR visualizes the motion of heart when CPR techniques are applied. 

###CORE FEATURES
- scalable and manipulable heart model what could easily be mapped onto the physical CPR training set
- Robust gesture detector that helps the trainee understand the exact pose for both hands
- Compression counter and predicted count per minute (feature still in progress) that visualizes whether the rate of compression is within the right range

##How we built it
using MRTK3
- Spatial Awareness
- Object Manipulator
- UI Toolkit

using Oculus Interaction SDK
- Passthrough API

##What's next for CPR Peer
Improve the animation by building full-body scale model to better represent the blood flow to the rest parts of human body, to better visualize;
The built-in hand-tracking plug-ins provided by MRTK and Oculus do not work well when both hands overlap; if there are future opportunities we would like to improve in that as well.
