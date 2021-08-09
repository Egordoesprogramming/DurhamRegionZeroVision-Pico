# DurhamRegionZeroVision-Pico
Unfortunately this version of Distracted Drivers is incomplete because of the limited time I had and the lack of manpower. However the biggest issue was concerning hardware, specifically the Pico Neo 2. The first issue I faced was that it is impossible to stream Unity to a Pico device. This significantly slowed down the development process and testing, because with each development update a new standalone executable needs to be built and deployed to Pico. This also meant that a separate wheel controller cannot be used and the control scheme was limited to Pico controllers. As the development continued more complications appeared with Pico Neo 2. The issue was the way PicoSDK reads eye tracking input from a player and how it projects this eye tracking vector. The eye tracking only works if the player is stationary and if the object they are observing is big enough. These kinds of restraints directly affected my simulator and the decision was made to focus on Tobii development.

Although this simulator is incomplete, you can still download the project and drive around or check out my eye tracking script for Pico (check out User Manual for more details).

Additionally you can check out the Demos:

Eye Tracking proof of concept: https://youtu.be/hIhYrpYU4K0

Car Control Demo: https://youtu.be/H9Z8PDuTMdI


