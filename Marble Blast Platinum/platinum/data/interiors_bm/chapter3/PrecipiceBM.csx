<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2023/08/01 16:48:37">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="14">
        <SceneShape id="0" type="1" entityID="2" dl="0" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="3" dl="0" group="-1" locked="0" />
        <SceneShape id="2" type="1" entityID="4" dl="0" group="-1" locked="0" />
        <SceneShape id="3" type="1" entityID="6" dl="0" group="-1" locked="0" />
        <SceneShape id="4" type="1" entityID="7" dl="0" group="-1" locked="0" />
        <SceneShape id="5" type="1" entityID="8" dl="0" group="-1" locked="0" />
        <SceneShape id="6" type="1" entityID="10" dl="0" group="-1" locked="0" />
        <SceneShape id="7" type="1" entityID="11" dl="0" group="-1" locked="0" />
        <SceneShape id="8" type="1" entityID="14" dl="0" group="-1" locked="0" />
        <SceneShape id="9" type="1" entityID="15" dl="0" group="-1" locked="0" />
        <SceneShape id="10" type="1" entityID="16" dl="0" group="-1" locked="0" />
        <SceneShape id="11" type="1" entityID="18" dl="0" group="-1" locked="0" />
        <SceneShape id="12" type="1" entityID="19" dl="0" group="-1" locked="0" />
        <SceneShape id="13" type="1" entityID="20" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="21">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="2" classname="path_node" gametype="Torque" isPointEntity="1" origin="7 16 15" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="7 20 15" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="4" classname="path_node" gametype="Torque" isPointEntity="1" origin="7 16 15" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="5" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="6" classname="path_node" gametype="Torque" isPointEntity="1" origin="11 22 15" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="7" classname="path_node" gametype="Torque" isPointEntity="1" origin="11 18 15" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="8" classname="path_node" gametype="Torque" isPointEntity="1" origin="11 22 15" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="9" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="10" classname="path_node" gametype="Torque" isPointEntity="1" origin="16 24 12" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="11" classname="path_node" gametype="Torque" isPointEntity="1" origin="16 24 16" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="12" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                    <Entity id="13" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="14" classname="path_node" gametype="Torque" isPointEntity="1" origin="1 37 35" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="15" classname="path_node" gametype="Torque" isPointEntity="1" origin="9 37 35" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="16" classname="path_node" gametype="Torque" isPointEntity="1" origin="1 37 35" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="17" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="18" classname="path_node" gametype="Torque" isPointEntity="1" origin="19 35 35" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="19" classname="path_node" gametype="Torque" isPointEntity="1" origin="13 35 35" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="20" classname="path_node" gametype="Torque" isPointEntity="1" origin="19 35 35" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="417">
                    <Brush id="0" owner="0" type="0" pos="2 0 -5" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 0 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 7" />
                            <Vertex pos="4 2 -21" />
                            <Vertex pos="4 -2 7" />
                            <Vertex pos="4 -2 -21" />
                            <Vertex pos="-4 2 7" />
                            <Vertex pos="-4 2 -21" />
                            <Vertex pos="-4 -2 7" />
                            <Vertex pos="-4 -2 -21" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -256 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 256 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_tile09_C" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -21" album="" material="bm_grid_blank1" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="0 4 -5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 4 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 7" />
                            <Vertex pos="2 2 -21" />
                            <Vertex pos="2 -2 7" />
                            <Vertex pos="2 -2 -21" />
                            <Vertex pos="-2 2 7" />
                            <Vertex pos="-2 2 -21" />
                            <Vertex pos="-2 -2 7" />
                            <Vertex pos="-2 -2 -21" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -21" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="6 4 -4" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 4 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 8" />
                            <Vertex pos="4 2 -22" />
                            <Vertex pos="4 -2 8" />
                            <Vertex pos="4 -2 -22" />
                            <Vertex pos="-4 2 6" />
                            <Vertex pos="-4 2 -22" />
                            <Vertex pos="-4 -2 6" />
                            <Vertex pos="-4 -2 -22" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -256 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 256 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -6.791" album="" material="bm_tile09_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22" album="" material="bm_grid_blank1" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="12 6 -4" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 6 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 8" />
                            <Vertex pos="2 4 2" />
                            <Vertex pos="2 -4 8" />
                            <Vertex pos="2 -4 2" />
                            <Vertex pos="-2 4 8" />
                            <Vertex pos="-2 4 2" />
                            <Vertex pos="-2 -4 8" />
                            <Vertex pos="-2 -4 2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 256 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -256 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="9 8 -3.75" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 8 0 0 1 -3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 7.75" />
                            <Vertex pos="1 2 -22.25" />
                            <Vertex pos="1 -2 7.75" />
                            <Vertex pos="1 -2 -22.25" />
                            <Vertex pos="-1 2 8.25" />
                            <Vertex pos="-1 2 -22.25" />
                            <Vertex pos="-1 -2 8.25" />
                            <Vertex pos="-1 -2 -22.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 0 -1 736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 0 -1 736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -7.76114" album="" material="bm_tile09_A" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="7 8 -3.75" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 8 0 0 1 -3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 8.25" />
                            <Vertex pos="1 2 -22.25" />
                            <Vertex pos="1 -2 8.25" />
                            <Vertex pos="1 -2 -22.25" />
                            <Vertex pos="-1 2 7.75" />
                            <Vertex pos="-1 2 -22.25" />
                            <Vertex pos="-1 -2 7.75" />
                            <Vertex pos="-1 -2 -22.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 0 -1 736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 0 -1 736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -7.76114" album="" material="bm_tile09_A" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="5 8 -3.75" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 8 0 0 1 -3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 7.75" />
                            <Vertex pos="1 2 -22.25" />
                            <Vertex pos="1 -2 7.75" />
                            <Vertex pos="1 -2 -22.25" />
                            <Vertex pos="-1 2 8.25" />
                            <Vertex pos="-1 2 -22.25" />
                            <Vertex pos="-1 -2 8.25" />
                            <Vertex pos="-1 -2 -22.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 0 -1 736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 0 -1 736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -7.76114" album="" material="bm_tile09_A" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="3 8 -3.75" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 8 0 0 1 -3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 8.25" />
                            <Vertex pos="1 2 -22.25" />
                            <Vertex pos="1 -2 8.25" />
                            <Vertex pos="1 -2 -22.25" />
                            <Vertex pos="-1 2 7.75" />
                            <Vertex pos="-1 2 -22.25" />
                            <Vertex pos="-1 -2 7.75" />
                            <Vertex pos="-1 -2 -22.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 0 -1 736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 0 -1 736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -7.76114" album="" material="bm_tile09_A" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="0 8 -4" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 8 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 8" />
                            <Vertex pos="2 2 -22" />
                            <Vertex pos="2 -2 8" />
                            <Vertex pos="2 -2 -22" />
                            <Vertex pos="-2 2 8" />
                            <Vertex pos="-2 2 -22" />
                            <Vertex pos="-2 -2 8" />
                            <Vertex pos="-2 -2 -22" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="0 12 -3" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 12 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 9" />
                            <Vertex pos="2 2 -23" />
                            <Vertex pos="2 -2 7" />
                            <Vertex pos="2 -2 -23" />
                            <Vertex pos="-2 2 9" />
                            <Vertex pos="-2 2 -23" />
                            <Vertex pos="-2 -2 7" />
                            <Vertex pos="-2 -2 -23" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -7.15542" album="" material="bm_tile09_A" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -23" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="2 16 -3" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 16 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 9" />
                            <Vertex pos="4 2 -23" />
                            <Vertex pos="4 -2 9" />
                            <Vertex pos="4 -2 -23" />
                            <Vertex pos="-4 2 9" />
                            <Vertex pos="-4 2 -23" />
                            <Vertex pos="-4 -2 9" />
                            <Vertex pos="-4 -2 -23" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -256 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 256 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -9" album="" material="bm_tile09_C" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -23" album="" material="bm_grid_blank1" texgens="-1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="4 12 -3" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 12 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 9" />
                            <Vertex pos="2 2 -23" />
                            <Vertex pos="2 -2 9" />
                            <Vertex pos="2 -2 -23" />
                            <Vertex pos="-2 2 9" />
                            <Vertex pos="-2 2 -23" />
                            <Vertex pos="-2 -2 9" />
                            <Vertex pos="-2 -2 -23" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -9" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -23" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="4 12 6.25" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 12 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="8 12 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 12 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 9.25" />
                            <Vertex pos="2 2 -23.25" />
                            <Vertex pos="2 -2 9.25" />
                            <Vertex pos="2 -2 -23.25" />
                            <Vertex pos="-2 2 9.25" />
                            <Vertex pos="-2 2 -23.25" />
                            <Vertex pos="-2 -2 9.25" />
                            <Vertex pos="-2 -2 -23.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -9.25" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -23.25" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="8 12 6.75" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 12 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="12 12 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 12 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 9.5" />
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 -2 9.5" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="-2 2 9.5" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 -2 9.5" />
                            <Vertex pos="-2 -2 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 576 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 576 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 576 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 576 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -9.5" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 0.5" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="12 12 7.25" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 12 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="16 12 -2.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 12 0 0 1 -2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 9.75" />
                            <Vertex pos="2 2 -23.75" />
                            <Vertex pos="2 -2 9.75" />
                            <Vertex pos="2 -2 -23.75" />
                            <Vertex pos="-2 2 9.75" />
                            <Vertex pos="-2 2 -23.75" />
                            <Vertex pos="-2 -2 9.75" />
                            <Vertex pos="-2 -2 -23.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -9.75" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -23.75" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="16 8 -2.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 8 0 0 1 -2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 9.75" />
                            <Vertex pos="2 2 -23.75" />
                            <Vertex pos="2 -2 9.75" />
                            <Vertex pos="2 -2 -23.75" />
                            <Vertex pos="-2 2 9.75" />
                            <Vertex pos="-2 2 -23.75" />
                            <Vertex pos="-2 -2 9.75" />
                            <Vertex pos="-2 -2 -23.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -9.75" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -23.75" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="16 8 8" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 8 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 2 -0.5" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="2 -2 -0.5" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 -2 0.5" />
                            <Vertex pos="-2 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_friction_mud" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="16 4 -1.75" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 4 0 0 1 -1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 10.25" />
                            <Vertex pos="2 2 -2.25" />
                            <Vertex pos="2 -2 10.25" />
                            <Vertex pos="2 -2 -2.25" />
                            <Vertex pos="-2 2 10.25" />
                            <Vertex pos="-2 2 -2.25" />
                            <Vertex pos="-2 -2 10.25" />
                            <Vertex pos="-2 -2 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10.25" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.25" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="16 4 9" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 4 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 2 -0.5" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="2 -2 -0.5" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 -2 0.5" />
                            <Vertex pos="-2 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_friction_mud" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="20 4 -1.25" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 4 0 0 1 -1.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 10.75" />
                            <Vertex pos="2 2 -24.75" />
                            <Vertex pos="2 -2 10.75" />
                            <Vertex pos="2 -2 -24.75" />
                            <Vertex pos="-2 2 10.75" />
                            <Vertex pos="-2 2 -24.75" />
                            <Vertex pos="-2 -2 10.75" />
                            <Vertex pos="-2 -2 -24.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10.75" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -24.75" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="20 4 10" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 4 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 2 -0.5" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="2 -2 -0.5" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 -2 0.5" />
                            <Vertex pos="-2 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="20 12 -2.25" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 12 0 0 1 -2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 9.75" />
                            <Vertex pos="2 2 -23.75" />
                            <Vertex pos="2 -2 9.75" />
                            <Vertex pos="2 -2 -23.75" />
                            <Vertex pos="-2 2 9.75" />
                            <Vertex pos="-2 2 -23.75" />
                            <Vertex pos="-2 -2 9.75" />
                            <Vertex pos="-2 -2 -23.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -9.75" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -23.75" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="20 12 7.75" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 12 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="20 7 10.25" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 7 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="2 -1 0.25" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 1 -0.25" />
                            <Vertex pos="-2 -1 0.25" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 384 0 0 -1 -1056 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_trim" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 -1056 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="20 16 -2" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 16 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 10" />
                            <Vertex pos="2 2 -24" />
                            <Vertex pos="2 -2 10" />
                            <Vertex pos="2 -2 -24" />
                            <Vertex pos="-2 2 10" />
                            <Vertex pos="-2 2 -24" />
                            <Vertex pos="-2 -2 10" />
                            <Vertex pos="-2 -2 -24" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -24" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="20 16 8.25" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 16 0 0 1 8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="15 16 1" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 16 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 13" />
                            <Vertex pos="3 2 -3" />
                            <Vertex pos="3 -2 13" />
                            <Vertex pos="3 -2 -3" />
                            <Vertex pos="-3 2 13" />
                            <Vertex pos="-3 2 -3" />
                            <Vertex pos="-3 -2 13" />
                            <Vertex pos="-3 -2 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="" material="bm_tile08_C" texgens="1 0 0 -256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank1" texgens="-1 0 0 128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="11 16 1" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 16 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 13" />
                            <Vertex pos="1 2 -3" />
                            <Vertex pos="1 -2 13" />
                            <Vertex pos="1 -2 -3" />
                            <Vertex pos="-1 2 13" />
                            <Vertex pos="-1 2 -3" />
                            <Vertex pos="-1 -2 13" />
                            <Vertex pos="-1 -2 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="" material="bm_tile11_C" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="9 16 1" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 16 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 13" />
                            <Vertex pos="1 2 -27" />
                            <Vertex pos="1 -2 13" />
                            <Vertex pos="1 -2 -27" />
                            <Vertex pos="-1 2 13" />
                            <Vertex pos="-1 2 -27" />
                            <Vertex pos="-1 -2 13" />
                            <Vertex pos="-1 -2 -27" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="" material="bm_tile08_C" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="7 16 1" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 16 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 13" />
                            <Vertex pos="1 2 -27" />
                            <Vertex pos="1 -2 13" />
                            <Vertex pos="1 -2 -27" />
                            <Vertex pos="-1 2 13" />
                            <Vertex pos="-1 2 -27" />
                            <Vertex pos="-1 -2 13" />
                            <Vertex pos="-1 -2 -27" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="" material="bm_tile11_C" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="5 16 12" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 16 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 2" />
                            <Vertex pos="1 2 -2" />
                            <Vertex pos="1 -2 2" />
                            <Vertex pos="1 -2 -2" />
                            <Vertex pos="-1 2 2" />
                            <Vertex pos="-1 2 -9.53674e-007" />
                            <Vertex pos="-1 -2 2" />
                            <Vertex pos="-1 -2 -9.53674e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile08_C" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.707107" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="2 15 13.5" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 15 0 0 1 13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.500001" />
                            <Vertex pos="2 1 -1.5" />
                            <Vertex pos="2 -1 0.500001" />
                            <Vertex pos="2 -1 -1.5" />
                            <Vertex pos="-2 1 1.5" />
                            <Vertex pos="-2 1 -1.5" />
                            <Vertex pos="-2 -1 1.5" />
                            <Vertex pos="-2 -1 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 384 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -384 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242535 0 0.970143 -0.970143" album="" material="bm_tile08_A" texgens="1 0 0 0 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.5" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="-1 16 13.5" rot="1 0 0 0" scale="" transform="1 0 0 -1 0 1 0 16 0 0 1 13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1.5" />
                            <Vertex pos="1 2 -1.5" />
                            <Vertex pos="1 -2 1.5" />
                            <Vertex pos="1 -2 -1.5" />
                            <Vertex pos="-1 2 1.5" />
                            <Vertex pos="-1 2 -1.5" />
                            <Vertex pos="-1 -2 1.5" />
                            <Vertex pos="-1 -2 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="" material="bm_tile08_C" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.5" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="2 17 14" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 17 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 2" />
                            <Vertex pos="2 1 -2" />
                            <Vertex pos="2 -1 2" />
                            <Vertex pos="2 -1 -2" />
                            <Vertex pos="-2 1 1" />
                            <Vertex pos="-2 1 -2" />
                            <Vertex pos="-2 -1 1" />
                            <Vertex pos="-2 -1 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 384 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -384 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -1.45521" album="" material="bm_tile08_A" texgens="1 0 0 0 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="5 17 15.75" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 17 0 0 1 15.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_trim" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -640 0 0 -1 -1504 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 0 -1 -1504 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_trim" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_C" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="1" type="999" pos="7 16 15" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 16 0 0 1 15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1" />
                            <Vertex pos="1 2 -1" />
                            <Vertex pos="1 -2 1" />
                            <Vertex pos="1 -2 -1" />
                            <Vertex pos="-1 2 1" />
                            <Vertex pos="-1 2 -1" />
                            <Vertex pos="-1 -2 1" />
                            <Vertex pos="-1 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank2" texgens="0 1 0 512 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank2" texgens="0 -1 0 -512 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank2" texgens="-1 0 0 -128 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile01_D" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank2" texgens="-1 0 0 -128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="5" type="999" pos="11 22 15" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 22 0 0 1 15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 1" />
                            <Vertex pos="1 4 -1" />
                            <Vertex pos="1 -4 1" />
                            <Vertex pos="1 -4 -1" />
                            <Vertex pos="-1 4 1" />
                            <Vertex pos="-1 4 -1" />
                            <Vertex pos="-1 -4 1" />
                            <Vertex pos="-1 -4 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank2" texgens="0 1 0 768 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank2" texgens="0 -1 0 -768 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank2" texgens="-1 0 0 -128 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile01_D" texgens="1 0 0 256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank2" texgens="-1 0 0 -128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="13 24 2" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 24 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 14" />
                            <Vertex pos="1 2 -28" />
                            <Vertex pos="1 -2 14" />
                            <Vertex pos="1 -2 -28" />
                            <Vertex pos="-1 2 14" />
                            <Vertex pos="-1 2 -28" />
                            <Vertex pos="-1 -2 14" />
                            <Vertex pos="-1 -2 -28" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -384 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_tile08_C" texgens="1 0 0 -768 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -28" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="9" type="999" pos="16 24 2" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 24 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 14" />
                            <Vertex pos="2 2 6" />
                            <Vertex pos="2 -2 14" />
                            <Vertex pos="2 -2 6" />
                            <Vertex pos="-2 2 14" />
                            <Vertex pos="-2 2 6" />
                            <Vertex pos="-2 -2 14" />
                            <Vertex pos="-2 -2 6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -1024 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank2" texgens="-1 0 0 -256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank2" texgens="1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_tile03_D" texgens="1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 6" album="" material="bm_grid_blank2" texgens="-1 0 0 -256 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="20 22 4" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 22 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 16" />
                            <Vertex pos="2 4 -8" />
                            <Vertex pos="2 -4 16" />
                            <Vertex pos="2 -4 -8" />
                            <Vertex pos="-2 4 16" />
                            <Vertex pos="-2 4 -8" />
                            <Vertex pos="-2 -4 16" />
                            <Vertex pos="-2 -4 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 256 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -256 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank1" texgens="-1 0 0 256 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank1" texgens="1 0 0 -256 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_tile08_C" texgens="1 0 0 -512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank1" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="15 20 4" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 20 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 16" />
                            <Vertex pos="3 2 -10" />
                            <Vertex pos="3 -2 16" />
                            <Vertex pos="3 -2 -10" />
                            <Vertex pos="-3 2 16" />
                            <Vertex pos="-3 2 -10" />
                            <Vertex pos="-3 -2 16" />
                            <Vertex pos="-3 -2 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -384 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_tile08_C" texgens="1 0 0 -768 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank1" texgens="-1 0 0 384 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="11 20 19.75" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 20 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.25" />
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -2 0.25" />
                            <Vertex pos="-1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 128 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_trim" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_C" texgens="1 0 0 -256 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="12 24 19.75" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 24 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_C" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="4 22 4" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 22 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 16" />
                            <Vertex pos="6 4 -30" />
                            <Vertex pos="6 -4 16" />
                            <Vertex pos="6 -4 -30" />
                            <Vertex pos="-6 4 16" />
                            <Vertex pos="-6 4 -30" />
                            <Vertex pos="-6 -4 16" />
                            <Vertex pos="-6 -4 -30" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank1" texgens="0 1 0 256 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank1" texgens="0 -1 0 -256 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank1" texgens="-1 0 0 768 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank1" texgens="1 0 0 -768 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_tile08_C" texgens="1 0 0 -1536 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -30" album="" material="bm_grid_blank1" texgens="-1 0 0 768 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="-3 26 19.75" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 26 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 0.25" />
                            <Vertex pos="1 4 -0.25" />
                            <Vertex pos="1 -7.5 0.25" />
                            <Vertex pos="1 -7.5 -0.25" />
                            <Vertex pos="-1 4 0.25" />
                            <Vertex pos="-1 4 -0.25" />
                            <Vertex pos="-1 -7.5 0.25" />
                            <Vertex pos="-1 -7.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 256 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -256 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank1" texgens="-1 0 0 128 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7.5" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_physics_propulsion" texgens="1 0 0 -256 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 128 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="-1 28 6" rot="1 0 0 0" scale="" transform="1 0 0 -1 0 1 0 28 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 18" />
                            <Vertex pos="1 2 -32" />
                            <Vertex pos="1 -2 18" />
                            <Vertex pos="1 -2 -32" />
                            <Vertex pos="-1 2 18" />
                            <Vertex pos="-1 2 -32" />
                            <Vertex pos="-1 -2 18" />
                            <Vertex pos="-1 -2 -32" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 1152 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -1152 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="" material="bm_tile08_C" texgens="1 0 0 -2304 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -32" album="" material="bm_grid_blank1" texgens="-1 0 0 1152 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="2 28 6.25" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 28 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 17.75" />
                            <Vertex pos="2 2 -32.25" />
                            <Vertex pos="2 -2 18.25" />
                            <Vertex pos="2 -2 -32.25" />
                            <Vertex pos="-2 2 17.75" />
                            <Vertex pos="-2 2 -32.25" />
                            <Vertex pos="-2 -2 18.25" />
                            <Vertex pos="-2 -2 -32.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 -544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 0 -1 -544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -1280 0 0 -1 -544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.124035 0.992278 -17.861" album="" material="bm_friction_ice" texgens="1 0 0 -2560 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -32.25" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="6 28 6.5" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 28 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 18.5" />
                            <Vertex pos="2 2 -32.5" />
                            <Vertex pos="2 -2 18" />
                            <Vertex pos="2 -2 -32.5" />
                            <Vertex pos="-2 2 18.5" />
                            <Vertex pos="-2 2 -32.5" />
                            <Vertex pos="-2 -2 18" />
                            <Vertex pos="-2 -2 -32.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 -576 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -576 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 0 -1 -576 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -1280 0 0 -1 -576 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.124035 0.992278 -18.1091" album="" material="bm_friction_ice" texgens="1 0 0 -2560 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -32.5" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="10 28 6.5" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 28 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 18.5" />
                            <Vertex pos="2 2 -32.5" />
                            <Vertex pos="2 -2 18.5" />
                            <Vertex pos="2 -2 -32.5" />
                            <Vertex pos="-2 2 18.5" />
                            <Vertex pos="-2 2 -32.5" />
                            <Vertex pos="-2 -2 18.5" />
                            <Vertex pos="-2 -2 -32.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 -576 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -576 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 0 -1 -576 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -1280 0 0 -1 -576 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18.5" album="" material="bm_friction_ice" texgens="1 0 0 -2560 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -32.5" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="16 28 8" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 28 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 20" />
                            <Vertex pos="4 2 -34" />
                            <Vertex pos="4 -2 20" />
                            <Vertex pos="4 -2 -34" />
                            <Vertex pos="-4 2 17" />
                            <Vertex pos="-4 2 -34" />
                            <Vertex pos="-4 -2 17" />
                            <Vertex pos="-4 -2 -34" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 1024 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -1024 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.351123 0 0.936329 -17.3221" album="" material="bm_friction_ice" texgens="1 0 0 -2048 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -34" album="" material="bm_grid_blank1" texgens="-1 0 0 1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="21 28 8" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 28 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 20" />
                            <Vertex pos="1 2 -34" />
                            <Vertex pos="1 -2 20" />
                            <Vertex pos="1 -2 -34" />
                            <Vertex pos="-1 2 20" />
                            <Vertex pos="-1 2 -34" />
                            <Vertex pos="-1 -2 20" />
                            <Vertex pos="-1 -2 -34" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -1408 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -20" album="" material="bm_tile08_C" texgens="1 0 0 -2816 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -34" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="21 28 29" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 28 0 0 1 29 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1" />
                            <Vertex pos="1 2 -1" />
                            <Vertex pos="1 -2 1" />
                            <Vertex pos="1 -2 -1" />
                            <Vertex pos="-1 2 1" />
                            <Vertex pos="-1 2 -1" />
                            <Vertex pos="-1 -2 1" />
                            <Vertex pos="-1 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 -3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_friction_sand" texgens="0 -1 0 0 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 0 -1 -3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -1408 0 0 -1 -3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile07_C" texgens="1 0 0 -2816 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="21 32 9" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 32 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 21" />
                            <Vertex pos="1 2 -35" />
                            <Vertex pos="1 -2 21" />
                            <Vertex pos="1 -2 -35" />
                            <Vertex pos="-1 2 21" />
                            <Vertex pos="-1 2 -35" />
                            <Vertex pos="-1 -2 21" />
                            <Vertex pos="-1 -2 -35" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -1408 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -21" album="" material="bm_tile07_C" texgens="1 0 0 -2816 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -35" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="-3 28 23.75" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 28 0 0 1 23.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.25" />
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -2 0.25" />
                            <Vertex pos="-1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_trim" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_C" texgens="1 0 0 -256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="16 33 9" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 33 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 3 21" />
                            <Vertex pos="4 3 -35" />
                            <Vertex pos="4 -3 21" />
                            <Vertex pos="4 -3 -35" />
                            <Vertex pos="-4 3 21" />
                            <Vertex pos="-4 3 -35" />
                            <Vertex pos="-4 -3 21" />
                            <Vertex pos="-4 -3 -35" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank1" texgens="0 -1 0 -128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank1" texgens="-1 0 0 1792 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank1" texgens="1 0 0 -1792 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -21" album="" material="bm_tile07_C" texgens="1 0 0 -3584 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -35" album="" material="bm_grid_blank1" texgens="-1 0 0 1792 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="10 33 10" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 33 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 20" />
                            <Vertex pos="2 3 -36" />
                            <Vertex pos="2 -3 20" />
                            <Vertex pos="2 -3 -36" />
                            <Vertex pos="-2 3 22" />
                            <Vertex pos="-2 3 -36" />
                            <Vertex pos="-2 -3 22" />
                            <Vertex pos="-2 -3 -36" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -128 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank1" texgens="-1 0 0 1536 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank1" texgens="1 0 0 -1536 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -18.783" album="" material="bm_tile07_A" texgens="1 0 0 -3072 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -36" album="" material="bm_grid_blank1" texgens="-1 0 0 1536 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="3 33 10" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 33 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 3 22" />
                            <Vertex pos="5 3 -36" />
                            <Vertex pos="5 -3 22" />
                            <Vertex pos="5 -3 -36" />
                            <Vertex pos="-5 3 22" />
                            <Vertex pos="-5 3 -36" />
                            <Vertex pos="-5 -3 22" />
                            <Vertex pos="-5 -3 -36" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_grid_blank1" texgens="0 -1 0 -128 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank1" texgens="-1 0 0 1920 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank1" texgens="1 0 0 -1920 0 0 -1 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -22" album="" material="bm_tile07_C" texgens="1 0 0 -3840 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -36" album="" material="bm_grid_blank1" texgens="-1 0 0 1920 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="-3 32 31.5" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 32 0 0 1 31.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1.5" />
                            <Vertex pos="1 2 -1.5" />
                            <Vertex pos="1 -2 0.500002" />
                            <Vertex pos="1 -2 -1.5" />
                            <Vertex pos="-1 2 1.5" />
                            <Vertex pos="-1 2 -1.5" />
                            <Vertex pos="-1 -2 0.500002" />
                            <Vertex pos="-1 -2 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 -3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 0 -1 -3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -1408 0 0 -1 -3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242535 0.970143 -0.970144" album="" material="bm_tile07_A" texgens="1 0 0 -2816 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.5" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="-3 36 31.5" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 36 0 0 1 31.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1.5" />
                            <Vertex pos="1 2 -1.5" />
                            <Vertex pos="1 -2 1.5" />
                            <Vertex pos="1 -2 -1.5" />
                            <Vertex pos="-1 2 1.5" />
                            <Vertex pos="-1 2 -1.5" />
                            <Vertex pos="-1 -2 1.5" />
                            <Vertex pos="-1 -2 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 -3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 0 -1 -3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -1408 0 0 -1 -3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="" material="bm_tile07_C" texgens="1 0 0 -2816 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.5" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="-1 37 11" rot="1 0 0 0" scale="" transform="1 0 0 -1 0 1 0 37 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.999996 23" />
                            <Vertex pos="1 1 -37" />
                            <Vertex pos="1 -1 23" />
                            <Vertex pos="1 -1 -37" />
                            <Vertex pos="-1 0.999996 22" />
                            <Vertex pos="-1 1 -37" />
                            <Vertex pos="-1 -1 22" />
                            <Vertex pos="-1 -1 -37" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 6.65585e-008 -0.999998" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -1408 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -20.1246" album="" material="bm_tile07_A" texgens="1 0 0 -2816 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -37" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="5 37 11" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 37 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 1 23" />
                            <Vertex pos="5 1 -37" />
                            <Vertex pos="5 -1 23" />
                            <Vertex pos="5 -1 -37" />
                            <Vertex pos="-5 1 23" />
                            <Vertex pos="-5 1 -37" />
                            <Vertex pos="-5 -1 23" />
                            <Vertex pos="-5 -1 -37" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="" material="bm_grid_blank1" texgens="0 -1 0 -128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 896 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -896 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -23" album="" material="bm_tile11_C" texgens="1 0 0 -1792 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -37" album="" material="bm_grid_blank1" texgens="-1 0 0 896 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="12 37 11" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 37 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 23" />
                            <Vertex pos="2 1 -37" />
                            <Vertex pos="2 -1 23" />
                            <Vertex pos="2 -1 -37" />
                            <Vertex pos="-2 1 23" />
                            <Vertex pos="-2 1 -37" />
                            <Vertex pos="-2 -1 23" />
                            <Vertex pos="-2 -1 -37" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -1280 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -23" album="" material="bm_tile07_C" texgens="1 0 0 -2560 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -37" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="16 35 33.75" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 35 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 0.25" />
                            <Vertex pos="4 1 -0.25" />
                            <Vertex pos="4 -1 0.25" />
                            <Vertex pos="4 -1 -0.25" />
                            <Vertex pos="-4 1 0.25" />
                            <Vertex pos="-4 1 -0.25" />
                            <Vertex pos="-4 -1 0.25" />
                            <Vertex pos="-4 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank1" texgens="0 1 0 640 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_trim" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 -256 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_trim" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile11_C" texgens="1 0 0 512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 -256 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="21 36 11" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 36 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 23" />
                            <Vertex pos="1 2 -37" />
                            <Vertex pos="1 -2 23" />
                            <Vertex pos="1 -2 -37" />
                            <Vertex pos="-1 2 23" />
                            <Vertex pos="-1 2 -37" />
                            <Vertex pos="-1 -2 23" />
                            <Vertex pos="-1 -2 -37" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -1408 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -23" album="" material="bm_tile07_C" texgens="1 0 0 -2816 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -37" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="19 37 12" rot="1 0 0 0" scale="" transform="1 0 0 19 0 1 0 37 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 24" />
                            <Vertex pos="1 1 -38" />
                            <Vertex pos="1 -1 24" />
                            <Vertex pos="1 -1 -38" />
                            <Vertex pos="-1 1 24" />
                            <Vertex pos="-1 1 -38" />
                            <Vertex pos="-1 -1 24" />
                            <Vertex pos="-1 -1 -38" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 -128 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -1408 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -24" album="" material="bm_tile07_C" texgens="1 0 0 -2816 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -38" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="19 39 12" rot="1 0 0 0" scale="" transform="1 0 0 19 0 1 0 39 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 23" />
                            <Vertex pos="1 1 -38" />
                            <Vertex pos="1 -0.999996 24" />
                            <Vertex pos="1 -1 -38" />
                            <Vertex pos="-1 1 23" />
                            <Vertex pos="-1 1 -38" />
                            <Vertex pos="-1 -0.999996 24" />
                            <Vertex pos="-1 -1 -38" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 -128 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 6.44115e-008 -0.999998" album="" material="bm_grid_blank1" texgens="1 0 0 -1408 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -21.019" album="" material="bm_tile07_A" texgens="1 0 0 -2816 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -38" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="21 39 11.5" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 39 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 23.5" />
                            <Vertex pos="1 1 -37.5" />
                            <Vertex pos="1 -0.999996 22.5" />
                            <Vertex pos="1 -1 -37.5" />
                            <Vertex pos="-1 1 23.5" />
                            <Vertex pos="-1 1 -37.5" />
                            <Vertex pos="-1 -0.999996 22.5" />
                            <Vertex pos="-1 -1 -37.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 -128 0 0 -1 -1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 -1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 0 -1 -1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 6.65585e-008 -0.999997" album="" material="bm_grid_blank1" texgens="1 0 0 -1408 0 0 -1 -1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -20.5718" album="" material="bm_tile07_A" texgens="1 0 0 -2816 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -37.5" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="15 37 12.5" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 37 0 0 1 12.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 24.5" />
                            <Vertex pos="1 1 -38.5" />
                            <Vertex pos="1 -1 24.5" />
                            <Vertex pos="1 -1 -38.5" />
                            <Vertex pos="-1 1 24.5" />
                            <Vertex pos="-1 1 -38.5" />
                            <Vertex pos="-1 -1 24.5" />
                            <Vertex pos="-1 -1 -38.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 -128 0 0 -1 -1344 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 -1344 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 0 -1 -1344 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -1408 0 0 -1 -1344 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -24.5" album="" material="bm_tile07_C" texgens="1 0 0 -2816 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -38.5" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="17 37 36.5" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 37 0 0 1 36.5 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1 0.999996 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 -4416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 1 3.99351e-006 -0.999998" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 0 -1 -4416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -1408 0 0 -1 -4416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 2" />
                        </Face>
                        <Face id="3" plane="0.447214 -0 0.894427 -0" album="" material="bm_tile07_A" texgens="1 0 0 -2816 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 0 4" />
                        </Face>
                        <Face id="4" plane="-0 -0 -1 -0.5" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="16 39 12.5" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 39 0 0 1 12.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 24.5" />
                            <Vertex pos="2 1 -38.5" />
                            <Vertex pos="2 -1 24.5" />
                            <Vertex pos="2 -1 -38.5" />
                            <Vertex pos="-2 1 24.5" />
                            <Vertex pos="-2 1 -38.5" />
                            <Vertex pos="-2 -1 24.5" />
                            <Vertex pos="-2 -1 -38.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 -128 0 0 -1 -1344 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 -1344 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 0 -1 -1344 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -1280 0 0 -1 -1344 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -24.5" album="" material="bm_tile07_C" texgens="1 0 0 -2560 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -38.5" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="13 39 13" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 39 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 24" />
                            <Vertex pos="1 1 -39" />
                            <Vertex pos="1 -1 24" />
                            <Vertex pos="1 -1 -39" />
                            <Vertex pos="-1 1 25" />
                            <Vertex pos="-1 1 -39" />
                            <Vertex pos="-1 -1 25" />
                            <Vertex pos="-1 -1 -39" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 -128 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 1152 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -1152 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -21.9135" album="" material="bm_tile07_A" texgens="1 0 0 -2304 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -39" album="" material="bm_grid_blank1" texgens="-1 0 0 1152 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="10 39 13" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 39 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 25" />
                            <Vertex pos="2 1 -39" />
                            <Vertex pos="2 -1 25" />
                            <Vertex pos="2 -1 -39" />
                            <Vertex pos="-2 1 25" />
                            <Vertex pos="-2 1 -39" />
                            <Vertex pos="-2 -1 25" />
                            <Vertex pos="-2 -1 -39" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 -128 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -1280 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -25" album="" material="bm_tile07_C" texgens="1 0 0 -2560 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -39" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="5 39 11" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 39 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 23" />
                            <Vertex pos="1 1 -37" />
                            <Vertex pos="1 -1 23" />
                            <Vertex pos="1 -1 -37" />
                            <Vertex pos="-1 1 23" />
                            <Vertex pos="-1 1 -37" />
                            <Vertex pos="-1 -1 23" />
                            <Vertex pos="-1 -1 -37" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 -128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 1152 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -1152 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -23" album="" material="bm_tile07_C" texgens="1 0 0 -2304 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -37" album="" material="bm_grid_blank1" texgens="-1 0 0 1152 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="7 39 17" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 39 0 0 1 17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 29" />
                            <Vertex pos="1 1 -43" />
                            <Vertex pos="1 -1 29" />
                            <Vertex pos="1 -1 -43" />
                            <Vertex pos="-1 1 29" />
                            <Vertex pos="-1 1 -43" />
                            <Vertex pos="-1 -1 29" />
                            <Vertex pos="-1 -1 -43" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 -128 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 1152 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -1152 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -29" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -43" album="" material="bm_grid_blank1" texgens="-1 0 0 1152 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="3 39 17" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 39 0 0 1 17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 29" />
                            <Vertex pos="1 1 -43" />
                            <Vertex pos="1 -1 29" />
                            <Vertex pos="1 -1 -43" />
                            <Vertex pos="-1 1 29" />
                            <Vertex pos="-1 1 -43" />
                            <Vertex pos="-1 -1 29" />
                            <Vertex pos="-1 -1 -43" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 -128 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 1152 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -1152 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -29" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -43" album="" material="bm_grid_blank1" texgens="-1 0 0 1152 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="17 37 11" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 37 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 23" />
                            <Vertex pos="1 1 -37" />
                            <Vertex pos="1 -1 23" />
                            <Vertex pos="1 -1 -37" />
                            <Vertex pos="-1 1 23" />
                            <Vertex pos="-1 1 -37" />
                            <Vertex pos="-1 -1 23" />
                            <Vertex pos="-1 -1 -37" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 -128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 1152 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -1152 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -23" album="" material="bm_tile07_C" texgens="1 0 0 -2304 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -37" album="" material="bm_grid_blank1" texgens="-1 0 0 1152 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="5 39 41" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 39 0 0 1 41 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 5" />
                            <Vertex pos="1 1 -5" />
                            <Vertex pos="1 -1 5" />
                            <Vertex pos="1 -1 -5" />
                            <Vertex pos="-1 1 5" />
                            <Vertex pos="-1 1 -5" />
                            <Vertex pos="-1 -1 5" />
                            <Vertex pos="-1 -1 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 -128 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 1152 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -1152 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_grid_blank1" texgens="-1 0 0 1152 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="0 39 13" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 39 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 25" />
                            <Vertex pos="2 1 -39" />
                            <Vertex pos="2 -1 25" />
                            <Vertex pos="2 -1 -39" />
                            <Vertex pos="-2 1 25" />
                            <Vertex pos="-2 1 -39" />
                            <Vertex pos="-2 -1 25" />
                            <Vertex pos="-2 -1 -39" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 -128 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -1280 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -25" album="" material="bm_tile07_C" texgens="1 0 0 -2560 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -39" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="5 44 17" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 44 0 0 1 17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 4 29" />
                            <Vertex pos="3 4 -43" />
                            <Vertex pos="3 -4 29" />
                            <Vertex pos="3 -4 -43" />
                            <Vertex pos="-3 4 29" />
                            <Vertex pos="-3 4 -43" />
                            <Vertex pos="-3 -4 29" />
                            <Vertex pos="-3 -4 -43" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank1" texgens="0 1 0 256 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank1" texgens="0 -1 0 -256 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank1" texgens="1 0 0 -1408 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -29" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -43" album="" material="bm_grid_blank1" texgens="-1 0 0 1408 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="0 42 14" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 42 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 26" />
                            <Vertex pos="2 2 -40" />
                            <Vertex pos="2 -2 24" />
                            <Vertex pos="2 -2 -40" />
                            <Vertex pos="-2 2 26" />
                            <Vertex pos="-2 2 -40" />
                            <Vertex pos="-2 -2 24" />
                            <Vertex pos="-2 -2 -40" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -1280 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -22.3607" album="" material="bm_tile07_A" texgens="1 0 0 -2560 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -40" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="0 46 14" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 46 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 26" />
                            <Vertex pos="2 2 -40" />
                            <Vertex pos="2 -2 26" />
                            <Vertex pos="2 -2 -40" />
                            <Vertex pos="-2 2 26" />
                            <Vertex pos="-2 2 -40" />
                            <Vertex pos="-2 -2 26" />
                            <Vertex pos="-2 -2 -40" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -1280 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -26" album="" material="bm_tile07_C" texgens="1 0 0 -2560 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -40" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="-4 46 14" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 46 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 26" />
                            <Vertex pos="2 2 -40" />
                            <Vertex pos="2 -2 26" />
                            <Vertex pos="2 -2 -40" />
                            <Vertex pos="-2 2 26" />
                            <Vertex pos="-2 2 -40" />
                            <Vertex pos="-2 -2 26" />
                            <Vertex pos="-2 -2 -40" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_friction_ice" texgens="1 0 0 0 0 0 -1 6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -26" album="" material="bm_tile07_C" texgens="1 0 0 -2560 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -40" album="" material="bm_grid_blank1" texgens="-1 0 0 1280 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="-4 21 -8" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 21 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 23 4" />
                            <Vertex pos="2 23 -18" />
                            <Vertex pos="2 -23 4" />
                            <Vertex pos="2 -23 -18" />
                            <Vertex pos="-2 23 4" />
                            <Vertex pos="-2 23 -18" />
                            <Vertex pos="-2 -23 4" />
                            <Vertex pos="-2 -23 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 2688 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -2688 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -23" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -23" album="" material="bm_grid_blank1" texgens="1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -1 0 -4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 -2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="5 47 50" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 47 0 0 1 50 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 4" />
                            <Vertex pos="3 1 -4" />
                            <Vertex pos="3 -1 4" />
                            <Vertex pos="3 -1 -4" />
                            <Vertex pos="-3 1 4" />
                            <Vertex pos="-3 1 -4" />
                            <Vertex pos="-3 -1 4" />
                            <Vertex pos="-3 -1 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank1" texgens="0 1 0 -128 0 0 -1 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank1" texgens="0 -1 0 128 0 0 -1 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 896 0 0 -1 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank1" texgens="1 0 0 -896 0 0 -1 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank1" texgens="-1 0 0 896 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="15 44 16" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 44 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 4 24" />
                            <Vertex pos="7 4 -42" />
                            <Vertex pos="7 -4 24" />
                            <Vertex pos="7 -4 -42" />
                            <Vertex pos="-7 4 28" />
                            <Vertex pos="-7 4 -42" />
                            <Vertex pos="-7 -4 28" />
                            <Vertex pos="-7 -4 -42" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_grid_blank1" texgens="0 1 0 256 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="" material="bm_grid_blank1" texgens="0 -1 0 -256 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank1" texgens="-1 0 0 896 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank1" texgens="1 0 0 -896 0 0 -1 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.274721 0 0.961524 -24.9996" album="" material="bm_grid_blank1" texgens="1 0 0 -640 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -42" album="" material="bm_grid_blank1" texgens="-1 0 0 896 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="-4 38.6209 0.97914" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 38.6209 0 0 1 0.97914 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -4.57938 4.97914" />
                            <Vertex pos="2 -5.37875 4.20551" />
                            <Vertex pos="-2 -4.57938 4.97914" />
                            <Vertex pos="-2 -5.37875 4.20551" />
                            <Vertex pos="2 5.37875 -4.97914" />
                            <Vertex pos="2 3.22375 -4.97914" />
                            <Vertex pos="-2 5.37875 -4.97914" />
                            <Vertex pos="-2 3.22375 -4.97914" />
                        </Vertices>
                        <Face id="0" plane="0 -0.695443 0.718581 -6.76261" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.729873 -0.683583 14.1211 0 0.125 0.139058" texRot="0" texScale="0.125 0.139058" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.707108 -0.707105 9.04608 0 -0.695419 0.718604 551.498 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 688.523 0 0 -1 3714.67 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.707112 0.707101 -0.282622" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.707105 -0.707109 1304.28 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.729859 -0.683598 -1.05085" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.707105 -0.707109 1304.28 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4.97914" album="" material="bm_grid_blank1" texgens="0 -1 0 136.17 1 0 0 377.67 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="-4 37.1312 0.592328" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 37.1312 0 0 1 0.592328 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -3.88906 4.59233" />
                            <Vertex pos="2 -4.71344 3.84505" />
                            <Vertex pos="-2 -3.88906 4.59233" />
                            <Vertex pos="-2 -4.71344 3.84505" />
                            <Vertex pos="2 4.71344 -4.59233" />
                            <Vertex pos="2 2.68563 -4.59233" />
                            <Vertex pos="-2 4.71344 -4.59233" />
                            <Vertex pos="-2 2.68563 -4.59233" />
                        </Vertices>
                        <Face id="0" plane="0 -0.671611 0.740904 -6.01441" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.729873 -0.683583 325.172 0 0.125 0.139058" texRot="0" texScale="0.125 0.139058" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.729863 -0.683594 9.62573 0 -0.671566 0.740945 575.43 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 879.203 0 0 -1 3764.18 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.729859 0.683598 -0.30084" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.683594 -0.729863 1280.33 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.751854 -0.65933 -1.00866" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.683594 -0.729863 1280.33 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4.59233" album="" material="bm_grid_blank1" texgens="0 -1 0 148.43 1 0 0 377.694 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="-4 35.6931 0.218688" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 35.6931 0 0 1 0.218688 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -3.27531 4.21869" />
                            <Vertex pos="2 -4.12375 3.49903" />
                            <Vertex pos="-2 -3.27531 4.21869" />
                            <Vertex pos="-2 -4.12375 3.49903" />
                            <Vertex pos="2 4.12375 -4.21869" />
                            <Vertex pos="2 2.21 -4.21869" />
                            <Vertex pos="-2 4.12375 -4.21869" />
                            <Vertex pos="-2 2.21 -4.21869" />
                        </Vertices>
                        <Face id="0" plane="0 -0.646858 0.762611 -5.33588" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.773006 -0.634399 33.1602 0 0.125 0.139057" texRot="0" texScale="0.125 0.139057" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.751842 -0.659344 10.2061 0 -0.646959 0.762525 597.143 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 1063.28 0 0 -1 3812.01 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.751854 0.65933 -0.318952" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.659344 -0.751842 1258.61 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.773011 -0.634392 -0.967948" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.659344 -0.751842 1258.61 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4.21869" album="" material="bm_grid_blank1" texgens="0 -1 0 157.96 1 0 0 377.751 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="-4 34.3005 -0.141155" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 34.3005 0 0 1 -0.141155 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -2.73109 3.85885" />
                            <Vertex pos="2 -3.60266 3.16704" />
                            <Vertex pos="-2 -2.73109 3.85885" />
                            <Vertex pos="-2 -3.60266 3.16704" />
                            <Vertex pos="2 3.60266 -3.85885" />
                            <Vertex pos="2 1.78859 -3.85885" />
                            <Vertex pos="-2 3.60266 -3.85885" />
                            <Vertex pos="-2 1.78859 -3.85885" />
                        </Vertices>
                        <Face id="0" plane="0 -0.621706 0.783251 -4.72038" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.773006 -0.634399 333.542 0 0.125 0.139057" texRot="0" texScale="0.125 0.139057" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.773009 -0.634395 10.7813 0 -0.621664 0.783284 616.844 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 1241.54 0 0 -1 3858.07 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.773011 0.634393 -0.336866" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.634395 -0.773009 1238.9 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.793348 -0.608768 -0.930171" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.634395 -0.773009 1238.9 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3.85885" album="" material="bm_grid_blank1" texgens="0 -1 0 165.025 1 0 0 377.829 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="-4 32.9467 -0.487055" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 32.9467 0 0 1 -0.487055 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -2.24886 3.51294" />
                            <Vertex pos="2 -3.14239 2.85033" />
                            <Vertex pos="-2 -2.24886 3.51294" />
                            <Vertex pos="-2 -3.14239 2.85033" />
                            <Vertex pos="2 3.14239 -3.51294" />
                            <Vertex pos="2 1.41739 -3.51294" />
                            <Vertex pos="-2 3.14239 -3.51294" />
                            <Vertex pos="-2 1.41739 -3.51294" />
                        </Vertices>
                        <Face id="0" plane="0 -0.595654 0.803241 -4.16128" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.812856 -0.582465 50.2349 0 0.125 0.139055" texRot="0" texScale="0.125 0.139055" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.793355 -0.608759 11.3411 0 -0.595692 0.803213 634.737 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 1414.83 0 0 -1 3902.34 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.793348 0.608769 -0.35444" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.608759 -0.793356 1220.99 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.812851 -0.582471 -0.89406" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.608759 -0.793356 1220.99 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3.51294" album="" material="bm_grid_blank1" texgens="0 -1 0 169.857 1 0 0 377.937 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="-4 31.6267 -0.81836" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 31.6267 0 0 1 -0.81836 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -1.82239 3.18164" />
                            <Vertex pos="2 -2.73739 2.54834" />
                            <Vertex pos="-2 -1.82239 3.18164" />
                            <Vertex pos="-2 -2.73739 2.54834" />
                            <Vertex pos="2 2.73739 -3.18164" />
                            <Vertex pos="2 1.09114 -3.18164" />
                            <Vertex pos="-2 2.73739 -3.18164" />
                            <Vertex pos="-2 1.09114 -3.18164" />
                        </Vertices>
                        <Face id="0" plane="0 -0.569112 0.82226 -3.65328" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.812856 -0.582465 341.496 0 0.125 0.139055" texRot="0" texScale="0.125 0.139055" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.812845 -0.58248 11.902 0 -0.569095 0.822272 650.992 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 1583.79 0 0 -1 3944.75 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.812852 0.582471 -0.37188" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.58248 -0.812845 1204.73 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.831478 -0.555558 -0.860328" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.58248 -0.812845 1204.73 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3.18164" album="" material="bm_grid_blank1" texgens="0 -1 0 172.686 1 0 0 378.068 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="-4 30.3361 -1.13501" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 30.3361 0 0 1 -1.13501 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -1.4468 2.86499" />
                            <Vertex pos="2 -2.38173 2.26216" />
                            <Vertex pos="-2 -1.4468 2.86499" />
                            <Vertex pos="-2 -2.38173 2.26216" />
                            <Vertex pos="2 2.38173 -2.86499" />
                            <Vertex pos="2 0.806515 -2.86499" />
                            <Vertex pos="-2 2.38173 -2.86499" />
                            <Vertex pos="-2 0.806515 -2.86499" />
                        </Vertices>
                        <Face id="0" plane="0 -0.541904 0.84044 -3.19188" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.849201 -0.52807 65.4487 0 0.125 0.139058" texRot="0" texScale="0.125 0.139058" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.831471 -0.555568 12.4401 0 -0.541916 0.840433 665.758 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 1748.98 0 0 -1 3985.28 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.831478 0.555558 -0.388687" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.555568 -0.831471 1189.95 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.849204 -0.528065 -0.828006" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.555568 -0.831471 1189.95 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.86499" album="" material="bm_grid_blank1" texgens="0 -1 0 173.666 1 0 0 378.227 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="-4 29.0713 -1.43643" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 29.0713 0 0 1 -1.43643 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -1.11691 2.56357" />
                            <Vertex pos="2 -2.07137 1.9915" />
                            <Vertex pos="-2 -1.11691 2.56357" />
                            <Vertex pos="-2 -2.07137 1.9915" />
                            <Vertex pos="2 2.07137 -2.56357" />
                            <Vertex pos="2 0.558468 -2.56357" />
                            <Vertex pos="-2 2.07137 -2.56357" />
                            <Vertex pos="-2 0.558468 -2.56357" />
                        </Vertices>
                        <Face id="0" plane="0 -0.514095 0.857733 -2.77306" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.849201 -0.52807 349.19 0 0.125 0.139058" texRot="0" texScale="0.125 0.139058" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.849202 -0.528069 12.9684 0 -0.5141 0.85773 679.157 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 1910.88 0 0 -1 4023.86 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.849201 0.52807 -0.405264" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.528069 -0.849202 1176.54 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.866028 -0.499995 -0.798124" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.528069 -0.849202 1176.54 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.56357" album="" material="bm_grid_blank1" texgens="0 -1 0 172.98 1 0 0 378.407 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="-4 27.8286 -1.72246" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 27.8286 0 0 1 -1.72246 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.828751 2.27753" />
                            <Vertex pos="2 -1.80109 1.73717" />
                            <Vertex pos="-2 -0.828751 2.27753" />
                            <Vertex pos="-2 -1.80109 1.73717" />
                            <Vertex pos="2 1.80109 -2.27753" />
                            <Vertex pos="2 0.34481 -2.27753" />
                            <Vertex pos="-2 1.80109 -2.27753" />
                            <Vertex pos="-2 0.34481 -2.27753" />
                        </Vertices>
                        <Face id="0" plane="0 -0.485761 0.874092 -2.39334" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.881924 -0.471392 78.8862 0 0.125 0.139054" texRot="0" texScale="0.125 0.139054" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.866027 -0.499997 13.4734 0 -0.485765 0.87409 691.31 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 2069.94 0 0 -1 4060.48 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.866027 0.499997 -0.421036" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.499996 -0.866028 1164.38 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.881921 -0.471396 -0.769524" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.499996 -0.866028 1164.38 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.27753" album="" material="bm_grid_blank1" texgens="0 -1 0 170.774 1 0 0 378.614 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="-4 26.6056 -1.99265" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 26.6056 0 0 1 -1.99265 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.578047 2.00735" />
                            <Vertex pos="2 -1.56786 1.49894" />
                            <Vertex pos="-2 -0.578047 2.00735" />
                            <Vertex pos="-2 -1.56786 1.49894" />
                            <Vertex pos="2 1.56786 -2.00735" />
                            <Vertex pos="2 0.161234 -2.00735" />
                            <Vertex pos="-2 1.56786 -2.00735" />
                            <Vertex pos="-2 0.161234 -2.00735" />
                        </Vertices>
                        <Face id="0" plane="0 -0.456895 0.88952 -2.04969" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.881924 -0.471392 356.399 0 0.125 0.139054" texRot="0" texScale="0.125 0.139054" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.88192 -0.471398 13.968 0 -0.456901 0.889518 702.304 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 2226.48 0 0 -1 4095.06 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.881921 0.471398 -0.436468" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.471398 -0.881921 1153.37 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.896874 -0.442285 -0.743215" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.471398 -0.881921 1153.37 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.00735" album="" material="bm_grid_blank1" texgens="0 -1 0 167.192 1 0 0 378.841 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="-4 25.3995 -2.24685" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 25.3995 0 0 1 -2.24685 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.361734 1.75315" />
                            <Vertex pos="2 -1.36736 1.27744" />
                            <Vertex pos="-2 -0.361734 1.75315" />
                            <Vertex pos="-2 -1.36736 1.27744" />
                            <Vertex pos="2 1.36736 -1.75315" />
                            <Vertex pos="2 0.00579453 -1.75315" />
                            <Vertex pos="-2 1.36736 -1.75315" />
                            <Vertex pos="-2 0.00579453 -1.75315" />
                        </Vertices>
                        <Face id="0" plane="0 -0.427617 0.90396 -1.73946" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.910853 -0.412732 90.7183 0 0.125 0.139059" texRot="0" texScale="0.125 0.139059" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.896874 -0.442286 14.4305 0 -0.427568 0.903983 712.235 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 2380.87 0 0 -1 4127.6 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.896875 0.442284 -0.45096" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.442286 -0.896874 1143.43 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.910863 -0.41271 -0.718265" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.442286 -0.896874 1143.43 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75315" album="" material="bm_grid_blank1" texgens="0 -1 0 162.345 1 0 0 379.093 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="-4 24.2082 -2.4847" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 24.2082 0 0 1 -2.4847 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.176094 1.5153" />
                            <Vertex pos="2 -1.19706 1.0727" />
                            <Vertex pos="-2 -0.176094 1.5153" />
                            <Vertex pos="-2 -1.19706 1.0727" />
                            <Vertex pos="2 1.19706 -1.5153" />
                            <Vertex pos="2 -0.125092 -1.5153" />
                            <Vertex pos="-2 1.19706 -1.5153" />
                            <Vertex pos="-2 -0.125092 -1.5153" />
                        </Vertices>
                        <Face id="0" plane="0 -0.397745 0.917496 -1.46032" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.910853 -0.412732 363 0 0.125 0.139059" texRot="0" texScale="0.125 0.139059" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.910863 -0.412708 14.8797 0 -0.397723 0.917506 721.168 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 2533.35 0 0 -1 4158.04 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.910863 0.412709 -0.46498" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.412708 -0.910863 1134.49 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.923882 -0.382678 -0.695443" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.412708 -0.910863 1134.49 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.5153" album="" material="bm_grid_blank1" texgens="0 -1 0 156.375 1 0 0 379.362 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="-4 23.0298 -2.70601" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 23.0298 0 0 1 -2.70601 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.0187016 1.29399" />
                            <Vertex pos="2 -1.05327 0.885209" />
                            <Vertex pos="-2 -0.0187016 1.29399" />
                            <Vertex pos="-2 -1.05327 0.885209" />
                            <Vertex pos="2 1.05327 -1.29399" />
                            <Vertex pos="2 -0.23308 -1.29399" />
                            <Vertex pos="-2 1.05327 -1.29399" />
                            <Vertex pos="-2 -0.23308 -1.29399" />
                        </Vertices>
                        <Face id="0" plane="0 -0.367477 0.930033 -1.21033" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.935908 -0.352244 100.83 0 0.125 0.139054" texRot="0" texScale="0.125 0.139054" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.923881 -0.382679 15.2927 0 -0.367518 0.930017 729.164 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 2684.18 0 0 -1 4186.37 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.92388 0.382682 -0.477909" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.38268 -0.923882 1126.49 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.935906 -0.352249 -0.673948" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.38268 -0.923882 1126.49 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.29399" album="" material="bm_grid_blank1" texgens="0 -1 0 149.359 1 0 0 379.654 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="-4 21.8628 -2.9104" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 21.8628 0 0 1 -2.9104 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.113766 1.0896" />
                            <Vertex pos="2 -0.933954 0.714691" />
                            <Vertex pos="-2 0.113766 1.0896" />
                            <Vertex pos="-2 -0.933954 0.714691" />
                            <Vertex pos="2 0.933952 -1.0896" />
                            <Vertex pos="2 -0.321486 -1.0896" />
                            <Vertex pos="-2 0.933952 -1.0896" />
                            <Vertex pos="-2 -0.321486 -1.0896" />
                        </Vertices>
                        <Face id="0" plane="0 -0.336913 0.941536 -0.987568" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.935908 -0.352244 368.752 0 0.125 0.139054" texRot="0" texScale="0.125 0.139054" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.935905 -0.352252 15.6892 0 -0.336887 0.941545 736.292 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 2833.56 0 0 -1 4212.53 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.935907 0.352247 -0.490283" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.352252 -0.935905 1119.35 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.946931 -0.321437 -0.654662" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.352252 -0.935905 1119.35 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.0896" album="" material="bm_grid_blank1" texgens="0 -1 0 141.435 1 0 0 379.962 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="-4 20.7055 -3.09785" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 20.7055 0 0 1 -3.09785 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.223312 0.902149" />
                            <Vertex pos="2 -0.835783 0.561852" />
                            <Vertex pos="-2 0.223312 0.902149" />
                            <Vertex pos="-2 -0.835783 0.561852" />
                            <Vertex pos="2 0.835781 -0.902149" />
                            <Vertex pos="2 -0.391687 -0.902149" />
                            <Vertex pos="-2 0.835781 -0.902149" />
                            <Vertex pos="-2 -0.391687 -0.902149" />
                        </Vertices>
                        <Face id="0" plane="0 -0.305906 0.952062 -0.790589" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.956946 -0.290266 109.421 0 0.125 0.139057" texRot="0" texScale="0.125 0.139057" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.946931 -0.321436 16.0466 0 -0.305901 0.952064 742.598 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 2981.7 0 0 -1 4236.52 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.946931 0.321436 -0.501444" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.321436 -0.946931 1113.04 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.956941 -0.290282 -0.636699" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.321436 -0.946931 1113.04 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.902149" album="" material="bm_grid_blank1" texgens="0 -1 0 132.663 1 0 0 380.289 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="-4 19.5568 -3.268" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 19.5568 0 0 1 -3.268 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.312967 0.732002" />
                            <Vertex pos="2 -0.757061 0.426496" />
                            <Vertex pos="-2 0.312967 0.732002" />
                            <Vertex pos="-2 -0.757061 0.426496" />
                            <Vertex pos="2 0.757063 -0.732002" />
                            <Vertex pos="2 -0.446655 -0.732002" />
                            <Vertex pos="-2 0.757063 -0.732002" />
                            <Vertex pos="-2 -0.446655 -0.732002" />
                        </Vertices>
                        <Face id="0" plane="0 -0.274541 0.961575 -0.617953" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.956946 -0.290266 373.761 0 0.125 0.139057" texRot="0" texScale="0.125 0.139057" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.95694 -0.290286 16.3836 0 -0.274617 0.961554 748.125 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 3128.73 0 0 -1 4258.3 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.956941 0.290282 -0.511978" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.290286 -0.95694 1107.51 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.965928 -0.258809 -0.620886" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.290286 -0.95694 1107.51 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.732002" album="" material="bm_grid_blank1" texgens="0 -1 0 123.168 1 0 0 380.63 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="-4 18.4154 -3.42076" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 18.4154 0 0 1 -3.42076 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.384346 0.579241" />
                            <Vertex pos="2 -0.69475 0.30894" />
                            <Vertex pos="-2 0.384346 0.579241" />
                            <Vertex pos="-2 -0.69475 0.30894" />
                            <Vertex pos="2 0.694752 -0.579241" />
                            <Vertex pos="2 -0.487656 -0.579241" />
                            <Vertex pos="-2 0.694752 -0.579241" />
                            <Vertex pos="-2 -0.487656 -0.579241" />
                        </Vertices>
                        <Face id="0" plane="0 -0.242981 0.970031 -0.468493" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.973879 -0.227067 116.448 0 0.125 0.139057" texRot="0" texScale="0.125 0.139057" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.965927 -0.258815 16.6769 0 -0.242983 0.970031 752.908 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 3274.83 0 0 -1 4277.86 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.965927 0.258813 -0.521165" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.258815 -0.965927 1102.72 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.973877 -0.227075 -0.606448" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.258815 -0.965927 1102.72 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.579241" album="" material="bm_grid_blank1" texgens="0 -1 0 113.006 1 0 0 380.988 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="0" type="0" pos="-4 17.2803 -3.5559" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 17.2803 0 0 1 -3.5559 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.440296 0.444095" />
                            <Vertex pos="2 -0.647388 0.209187" />
                            <Vertex pos="-2 0.440296 0.444095" />
                            <Vertex pos="-2 -0.647388 0.209187" />
                            <Vertex pos="2 0.64739 -0.444095" />
                            <Vertex pos="2 -0.517452 -0.444095" />
                            <Vertex pos="-2 0.64739 -0.444095" />
                            <Vertex pos="-2 -0.517452 -0.444095" />
                        </Vertices>
                        <Face id="0" plane="0 -0.211104 0.977464 -0.341139" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.973879 -0.227067 377.829 0 0.125 0.139057" texRot="0" texScale="0.125 0.139057" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.973877 -0.227077 16.9486 0 -0.211086 0.977468 756.983 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 3420.12 0 0 -1 4295.16 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.973878 0.227073 -0.529637" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.227077 -0.973877 1098.64 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.980788 -0.195076 -0.594143" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.227077 -0.973877 1098.64 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.444095" album="" material="bm_grid_blank1" texgens="0 -1 0 102.289 1 0 0 381.357 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="0" type="0" pos="-4 16.1507 -3.67336" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 16.1507 0 0 1 -3.67336 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.482267 0.32664" />
                            <Vertex pos="2 -0.612203 0.127453" />
                            <Vertex pos="-2 0.482267 0.32664" />
                            <Vertex pos="-2 -0.612203 0.127453" />
                            <Vertex pos="2 0.612204 -0.32664" />
                            <Vertex pos="2 -0.537202 -0.32664" />
                            <Vertex pos="-2 0.612204 -0.32664" />
                            <Vertex pos="-2 -0.537202 -0.32664" />
                        </Vertices>
                        <Face id="0" plane="0 -0.179053 0.983839 -0.23501" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.986645 -0.162888 121.728 0 0.125 0.139056" texRot="0" texScale="0.125 0.139056" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.980786 -0.195086 17.1746 0 -0.179009 0.983848 760.377 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 3564.71 0 0 -1 4310.19 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.980788 0.195078 -0.536722" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.195086 -0.980786 1095.24 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.986633 -0.162959 -0.58325" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.195086 -0.980786 1095.24 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.32664" album="" material="bm_grid_blank1" texgens="0 -1 0 91.0695 1 0 0 381.737 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="-4 15.0256 -3.77295" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 15.0256 0 0 1 -3.77295 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.512858 0.227047" />
                            <Vertex pos="2 -0.58786 0.0638282" />
                            <Vertex pos="-2 0.512858 0.227047" />
                            <Vertex pos="-2 -0.58786 0.0638282" />
                            <Vertex pos="2 0.587859 -0.227046" />
                            <Vertex pos="2 -0.549579 -0.227046" />
                            <Vertex pos="-2 0.587859 -0.227046" />
                            <Vertex pos="-2 -0.549579 -0.227046" />
                        </Vertices>
                        <Face id="0" plane="0 -0.14668 0.989184 -0.149365" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.986645 -0.162888 380.879 0 0.125 0.139056" texRot="0" texScale="0.125 0.139056" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.986643 -0.162896 17.3759 0 -0.146713 0.989179 763.117 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 3708.72 0 0 -1 4322.94 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.986633 0.162959 -0.543002" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.162896 -0.986643 1092.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.991451 -0.130481 -0.574506" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.162896 -0.986643 1092.5 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.227046" album="" material="bm_grid_blank1" texgens="0 -1 0 79.4545 1 0 0 382.124 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="108" owner="0" type="0" pos="-4 13.9043 -3.85456" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 13.9043 0 0 1 -3.85456 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.533436 0.145437" />
                            <Vertex pos="2 -0.571718 0.0182502" />
                            <Vertex pos="-2 0.533436 0.145437" />
                            <Vertex pos="-2 -0.571718 0.0182502" />
                            <Vertex pos="2 0.571717 -0.145437" />
                            <Vertex pos="2 -0.555593 -0.145437" />
                            <Vertex pos="-2 0.571717 -0.145437" />
                            <Vertex pos="-2 -0.555593 -0.145437" />
                        </Vertices>
                        <Face id="0" plane="0 -0.114331 0.993443 -0.0834953" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.995183 -0.0980293 125.416 0 0.125 0.139056" texRot="0" texScale="0.125 0.139056" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.991445 -0.130522 17.5318 0 -0.114298 0.993447 765.225 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 3852.25 0 0 -1 4333.38 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.991451 0.130482 -0.547852" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.130522 -0.991446 1090.39 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.995183 -0.0980363 -0.567175" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.130522 -0.991446 1090.39 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.145437" album="" material="bm_grid_blank1" texgens="0 -1 0 67.4919 1 0 0 382.522 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="109" owner="0" type="0" pos="-4 12.7861 -3.91816" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 12.7861 0 0 1 -3.91816 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.546454 0.0818441" />
                            <Vertex pos="2 -0.562579 -0.00906229" />
                            <Vertex pos="-2 0.546454 0.0818441" />
                            <Vertex pos="-2 -0.562579 -0.00906229" />
                            <Vertex pos="2 0.562579 -0.0818439" />
                            <Vertex pos="2 -0.55783 -0.0818439" />
                            <Vertex pos="-2 0.562579 -0.0818439" />
                            <Vertex pos="-2 -0.55783 -0.0818439" />
                        </Vertices>
                        <Face id="0" plane="0 -0.0816951 0.996657 -0.0369279" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.995183 -0.0980293 382.932 0 0.125 0.139056" texRot="0" texScale="0.125 0.139056" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.995185 -0.0980178 17.6591 0 -0.0817075 0.996656 766.714 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 3995.38 0 0 -1 4341.52 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.995183 0.0980358 -0.551845" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.0980178 -0.995185 1088.89 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.997878 -0.0651115 -0.561975" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.0980178 -0.995185 1088.89 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.0818439" album="" material="bm_grid_blank1" texgens="0 -1 0 55.2835 1 0 0 382.925 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="0" type="0" pos="-4 11.6704 -3.96361" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 11.6704 0 0 1 -3.96361 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.553172 0.0363903" />
                            <Vertex pos="2 -0.557922 -0.0182035" />
                            <Vertex pos="-2 0.553172 0.0363903" />
                            <Vertex pos="-2 -0.557922 -0.0182035" />
                            <Vertex pos="2 0.557921 -0.0363903" />
                            <Vertex pos="2 -0.557328 -0.0363903" />
                            <Vertex pos="-2 0.557921 -0.0363903" />
                            <Vertex pos="-2 -0.557328 -0.0363903" />
                        </Vertices>
                        <Face id="0" plane="0 -0.049076 0.998795 -0.009199" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.999464 -0.0327241 127.514 0 0.125 0.139047" texRot="0" texScale="0.125 0.139047" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.997859 -0.0653987 17.7399 0 -0.0490586 0.998796 767.601 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 4138.19 0 0 -1 4347.34 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.997878 0.0651124 -0.554368" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.0653987 -0.997859 1088 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.999467 -0.0326447 -0.558219" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.0653987 -0.997859 1088 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.0363903" album="" material="bm_grid_blank1" texgens="0 -1 0 42.8735 1 0 0 383.333 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="111" owner="0" type="0" pos="-4 10.5565 -3.99091" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 10.5565 0 0 1 -3.99091 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="2 0.555942 0.009094" />
                            <Vertex pos="2 -0.556536 -0.00909376" />
                            <Vertex pos="-2 0.555942 0.009094" />
                            <Vertex pos="-2 -0.556536 -0.00909376" />
                            <Vertex pos="2 0.556536 -0.00909376" />
                            <Vertex pos="-2 0.556536 -0.00909376" />
                        </Vertices>
                        <Face id="0" plane="0 -0.0163467 0.999866 -4.97513e-006" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.999464 -0.0327241 383.936 0 0.125 0.139047" texRot="0" texScale="0.125 0.139047" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.999465 -0.0327193 17.7894 0 -0.0163865 0.999866 767.897 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 1 0" />
                        </Face>
                        <Face id="2" plane="-1 0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 4280.77 0 0 -1 4350.84 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.999467 0.032643 -0.555943" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.0327193 -0.999465 1087.71 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.00909376" album="" material="bm_grid_blank1" texgens="0 -1 0 30.3611 1 0 0 383.742 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 3 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="112" owner="0" type="0" pos="-4 43.9909 29.4436" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 43.9909 0 0 1 29.4436 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="2 -0.00906754 -0.555958" />
                            <Vertex pos="2 0.00906372 0.556553" />
                            <Vertex pos="-2 -0.00906754 -0.555958" />
                            <Vertex pos="-2 0.00906372 0.556553" />
                            <Vertex pos="2 0.00906372 -0.556551" />
                            <Vertex pos="-2 0.00906372 -0.556551" />
                        </Vertices>
                        <Face id="0" plane="0 -0.999867 0.0162954 -6.75861e-006" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.0327178 -0.999465 128.001 0 0.125 0.139057" texRot="0" texScale="0.125 0.139057" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 0 -1 17.8032 0 -0.999867 0.0163348 767.898 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 4 0 1" />
                        </Face>
                        <Face id="2" plane="-1 0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 1.15625 0 0 -1 71.2109 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 2" />
                        </Face>
                        <Face id="3" plane="0 -0.0326888 -0.999466 -0.555957" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 1 0 1087.71 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 2 0 4" />
                        </Face>
                        <Face id="4" plane="0 1 -0 -0.00906372" album="" material="bm_grid_blank1" texgens="0 0 1 42.9158 1 0 0 383.744 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="113" owner="0" type="0" pos="-4 43.9636 28.3296" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 43.9636 0 0 1 28.3296 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.0182838 0.558113" />
                            <Vertex pos="2 -0.0364037 -0.553331" />
                            <Vertex pos="-2 0.0182838 0.558113" />
                            <Vertex pos="-2 -0.0364037 -0.553331" />
                            <Vertex pos="2 0.0363998 0.557522" />
                            <Vertex pos="2 0.0363998 -0.558113" />
                            <Vertex pos="-2 0.0363998 0.557522" />
                            <Vertex pos="-2 0.0363998 -0.558113" />
                        </Vertices>
                        <Face id="0" plane="0 -0.998792 0.0491446 -0.00916651" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.0327178 -0.999465 384.5 0 0.125 0.139057" texRot="0" texScale="0.125 0.139057" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.0327151 -0.999465 17.8688 0 -0.998794 0.0490977 767.601 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 4.65625 0 0 -1 213.813 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.0326046 0.999468 -0.558412" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.999465 -0.0327152 1088 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.0655419 -0.99785 -0.554527" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.999465 -0.0327152 1088 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -0.0363998" album="" material="bm_grid_blank1" texgens="0 0 1 55.3875 1 0 0 383.333 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="0" type="0" pos="-4 43.9181 27.2138" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 43.9181 0 0 1 27.2138 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.00906372 0.562422" />
                            <Vertex pos="2 -0.0818748 -0.546295" />
                            <Vertex pos="-2 0.00906372 0.562422" />
                            <Vertex pos="-2 -0.0818748 -0.546295" />
                            <Vertex pos="2 0.0818787 0.55764" />
                            <Vertex pos="2 0.0818787 -0.562422" />
                            <Vertex pos="-2 0.0818787 0.55764" />
                            <Vertex pos="-2 0.0818787 -0.562422" />
                        </Vertices>
                        <Face id="0" plane="0 -0.996653 0.0817469 -0.0369429" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.0980253 -0.995184 128.996 0 0.125 0.139056" texRot="0" texScale="0.125 0.139056" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.0654045 -0.997859 17.978 0 -0.996654 0.0817323 766.718 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 10.4844 0 0 -1 356.629 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.0655316 0.99785 -0.561807" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.997859 -0.0654045 1088.89 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.0980092 -0.995185 -0.551689" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.997859 -0.0654045 1088.89 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -0.0818787" album="" material="bm_grid_blank1" texgens="0 0 1 67.6704 1 0 0 382.925 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="115" owner="0" type="0" pos="-4 43.8545 26.0957" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 43.8545 0 0 1 26.0957 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.01828 0.571877" />
                            <Vertex pos="2 -0.14547 -0.53359" />
                            <Vertex pos="-2 -0.01828 0.571877" />
                            <Vertex pos="-2 -0.14547 -0.53359" />
                            <Vertex pos="2 0.14547 0.55575" />
                            <Vertex pos="2 0.14547 -0.571875" />
                            <Vertex pos="-2 0.14547 0.55575" />
                            <Vertex pos="-2 0.14547 -0.571875" />
                        </Vertices>
                        <Face id="0" plane="0 -0.993446 0.114301 -0.0835265" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.0980253 -0.995184 386.538 0 0.125 0.139056" texRot="0" texScale="0.125 0.139056" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.0980137 -0.995185 18.1548 0 -0.99345 0.114264 765.224 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 18.6172 0 0 -1 499.758 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.0980113 0.995185 -0.567332" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.995185 -0.0980137 1090.37 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.130466 -0.991453 -0.548008" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.995185 -0.0980137 1090.37 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -0.14547" album="" material="bm_grid_blank1" texgens="0 0 1 79.7369 1 0 0 382.522 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="-4 43.773 24.9744" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 43.773 0 0 1 24.9744 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.0639076 0.587688" />
                            <Vertex pos="2 -0.227032 -0.512718" />
                            <Vertex pos="-2 -0.0639076 0.587688" />
                            <Vertex pos="-2 -0.227032 -0.512718" />
                            <Vertex pos="2 0.227032 0.549406" />
                            <Vertex pos="2 0.227032 -0.587687" />
                            <Vertex pos="-2 0.227032 0.549406" />
                            <Vertex pos="-2 0.227032 -0.587687" />
                        </Vertices>
                        <Face id="0" plane="0 -0.98919 0.146638 -0.149394" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.162881 -0.986646 131.034 0 0.125 0.139056" texRot="0" texScale="0.125 0.139056" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.130527 -0.991445 18.3793 0 -0.989173 0.146757 763.116 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 29.0625 0 0 -1 643.281 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.130456 0.991454 -0.574329" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.991445 -0.130527 1092.48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.162901 -0.986642 -0.542853" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.991445 -0.130527 1092.48 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -0.227032" album="" material="bm_grid_blank1" texgens="0 0 1 91.4689 1 0 0 382.124 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="117" owner="0" type="0" pos="-4 43.6733 23.8493" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 43.6733 0 0 1 23.8493 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.127346 0.612362" />
                            <Vertex pos="2 -0.326721 -0.482422" />
                            <Vertex pos="-2 -0.127346 0.612362" />
                            <Vertex pos="-2 -0.326721 -0.482422" />
                            <Vertex pos="2 0.326721 0.537392" />
                            <Vertex pos="2 0.326721 -0.612362" />
                            <Vertex pos="-2 0.326721 0.537392" />
                            <Vertex pos="-2 0.326721 -0.612362" />
                        </Vertices>
                        <Face id="0" plane="0 -0.983819 0.179167 -0.235" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.162881 -0.986646 390.261 0 0.125 0.139056" texRot="0" texScale="0.125 0.139056" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.162892 -0.986644 18.6707 0 -0.983848 0.179008 760.373 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 41.8203 0 0 -1 787.289 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.162902 0.986642 -0.583437" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.986644 -0.162892 1095.21 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.195036 -0.980796 -0.53688" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.986644 -0.162892 1095.21 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -0.326721" album="" material="bm_grid_blank1" texgens="0 0 1 102.836 1 0 0 381.735 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="118" owner="0" type="0" pos="-4 43.5559 22.7197" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 43.5559 0 0 1 22.7197 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.209373 0.647219" />
                            <Vertex pos="2 -0.444061 -0.440123" />
                            <Vertex pos="-2 -0.209373 0.647219" />
                            <Vertex pos="-2 -0.444061 -0.440123" />
                            <Vertex pos="2 0.444061 0.517281" />
                            <Vertex pos="2 0.444061 -0.647217" />
                            <Vertex pos="-2 0.444061 0.517281" />
                            <Vertex pos="-2 0.444061 -0.647217" />
                        </Vertices>
                        <Face id="0" plane="0 -0.977491 0.210978 -0.341209" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.227063 -0.97388 134.126 0 0.125 0.139057" texRot="0" texScale="0.125 0.139057" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.195092 -0.980785 19.0038 0 -0.977464 0.211102 756.978 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 56.8438 0 0 -1 931.883 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.195035 0.980796 -0.593955" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.980785 -0.195092 1098.61 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.22709 -0.973874 -0.529466" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.980785 -0.195092 1098.61 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -0.444061" album="" material="bm_grid_blank1" texgens="0 0 1 113.724 1 0 0 381.356 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="119" owner="0" type="0" pos="-4 43.4208 21.5846" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 43.4208 0 0 1 21.5846 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.30891 0.694935" />
                            <Vertex pos="2 -0.57922 -0.384499" />
                            <Vertex pos="-2 -0.30891 0.694935" />
                            <Vertex pos="-2 -0.57922 -0.384499" />
                            <Vertex pos="2 0.57922 0.487839" />
                            <Vertex pos="2 0.57922 -0.694937" />
                            <Vertex pos="-2 0.57922 0.487839" />
                            <Vertex pos="-2 0.57922 -0.694937" />
                        </Vertices>
                        <Face id="0" plane="0 -0.970047 0.242917 -0.468469" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.227063 -0.97388 395.533 0 0.125 0.139057" texRot="0" texScale="0.125 0.139057" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.227072 -0.973878 19.4171 0 -0.970037 0.242958 752.9 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 74.1406 0 0 -1 1077.17 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.22709 0.973874 -0.606629" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.973878 -0.227073 1102.68 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.258846 -0.965919 -0.521324" album="" material="bm_grid_blank1" texgens="-1 0 0 64 0 0.973878 -0.227073 1102.68 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -0.57922" album="" material="bm_grid_blank1" texgens="0 0 1 124.095 1 0 0 380.987 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="120" owner="0" type="0" pos="-4 43.268 20.4432" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 43.268 0 0 1 20.4432 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.426407 0.756876" />
                            <Vertex pos="2 -0.732033 -0.31278" />
                            <Vertex pos="-2 -0.426407 0.756876" />
                            <Vertex pos="-2 -0.732033 -0.31278" />
                            <Vertex pos="2 0.732033 0.446438" />
                            <Vertex pos="2 0.732033 -0.756876" />
                            <Vertex pos="-2 0.732033 0.446438" />
                            <Vertex pos="-2 0.732033 -0.756876" />
                        </Vertices>
                        <Face id="0" plane="0 -0.961522 0.274729 -0.617936" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.290302 -0.956935 138.167 0 0.125 0.139057" texRot="0" texScale="0.125 0.139057" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.258821 -0.965926 19.8605 0 -0.961558 0.274602 748.121 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 93.7031 0 0 -1 1223.27 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.258846 0.965919 -0.620707" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.965925 -0.258821 1107.45 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.290271 -0.956945 -0.511801" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.965925 -0.258821 1107.45 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -0.732033" album="" material="bm_grid_blank1" texgens="0 0 1 133.828 1 0 0 380.631 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="121" owner="0" type="0" pos="-4 43.0978 19.2945" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 43.0978 0 0 1 19.2945 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.561874 0.835989" />
                            <Vertex pos="2 -0.902187 -0.223455" />
                            <Vertex pos="-2 -0.561874 0.835989" />
                            <Vertex pos="-2 -0.902187 -0.223455" />
                            <Vertex pos="2 0.902187 0.391895" />
                            <Vertex pos="2 0.902187 -0.835987" />
                            <Vertex pos="-2 0.902187 0.391895" />
                            <Vertex pos="-2 0.902187 -0.835987" />
                        </Vertices>
                        <Face id="0" plane="0 -0.952087 0.305828 -0.790622" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.290302 -0.956935 402.511 0 0.125 0.139057" texRot="0" texScale="0.125 0.139057" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.290281 -0.956942 20.3772 0 -0.952062 0.305905 742.595 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 115.477 0 0 -1 1370.31 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.29027 0.956945 -0.6369" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.956941 -0.290281 1112.97 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.321453 -0.946925 -0.501606" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.956941 -0.290281 1112.97 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -0.902187" album="" material="bm_grid_blank1" texgens="0 0 1 142.885 1 0 0 380.288 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="-4 42.9105 18.1372" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 42.9105 0 0 1 18.1372 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.71484 0.933783" />
                            <Vertex pos="2 -1.08953 -0.113598" />
                            <Vertex pos="-2 -0.71484 0.933783" />
                            <Vertex pos="-2 -1.08953 -0.113598" />
                            <Vertex pos="2 1.08953 0.321255" />
                            <Vertex pos="2 1.08953 -0.933783" />
                            <Vertex pos="-2 1.08953 0.321255" />
                            <Vertex pos="-2 1.08953 -0.933783" />
                        </Vertices>
                        <Face id="0" plane="0 -0.941564 0.336835 -0.987598" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.352239 -0.935911 143.12 0 0.125 0.139057" texRot="0" texScale="0.125 0.139057" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.321441 -0.94693 20.9385 0 -0.941542 0.336895 736.297 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 139.461 0 0 -1 1518.44 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.321452 0.946926 -0.654436" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.946929 -0.321441 1119.27 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.352267 -0.9359 -0.490122" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.946929 -0.321441 1119.27 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -1.08953" album="" material="bm_grid_blank1" texgens="0 0 1 151.138 1 0 0 379.964 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="0" type="0" pos="-4 42.7059 16.9701" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 42.7059 0 0 1 16.9701 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -0.885002 1.0535" />
                            <Vertex pos="2 -1.29406 0.0185337" />
                            <Vertex pos="-2 -0.885002 1.0535" />
                            <Vertex pos="-2 -1.29406 0.0185337" />
                            <Vertex pos="2 1.29406 0.233313" />
                            <Vertex pos="2 1.29406 -1.0535" />
                            <Vertex pos="-2 1.29406 0.233313" />
                            <Vertex pos="-2 1.29406 -1.0535" />
                        </Vertices>
                        <Face id="0" plane="0 -0.929996 0.36757 -1.21028" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.352239 -0.935911 411.087 0 0.125 0.139057" texRot="0" texScale="0.125 0.139057" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.352247 -0.935907 21.5742 0 -0.930031 0.367482 729.168 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 165.641 0 0 -1 1667.82 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.352267 0.935899 -0.674213" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.935907 -0.352247 1126.38 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.382683 -0.92388 -0.478092" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.935907 -0.352247 1126.38 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -1.29406" album="" material="bm_grid_blank1" texgens="0 0 1 158.541 1 0 0 379.654 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="124" owner="0" type="0" pos="-4 42.4847 15.7918" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 42.4847 0 0 1 15.7918 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -1.07281 1.19687" />
                            <Vertex pos="2 -1.51531 0.176252" />
                            <Vertex pos="-2 -1.07281 1.19687" />
                            <Vertex pos="-2 -1.51531 0.176252" />
                            <Vertex pos="2 1.51531 0.124841" />
                            <Vertex pos="2 1.51531 -1.19687" />
                            <Vertex pos="-2 1.51531 0.124841" />
                            <Vertex pos="-2 1.51531 -1.19687" />
                        </Vertices>
                        <Face id="0" plane="0 -0.917479 0.397783 -1.46038" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.412727 -0.910855 149.066 0 0.125 0.139053" texRot="0" texScale="0.125 0.139053" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.382686 -0.923879 22.2443 0 -0.917494 0.397751 721.166 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 193.961 0 0 -1 1818.65 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.382682 0.92388 -0.69522" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.923879 -0.382686 1134.37 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.412699 -0.910868 -0.464824" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.923879 -0.382686 1134.37 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -1.51531" album="" material="bm_grid_blank1" texgens="0 0 1 164.955 1 0 0 379.364 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="125" owner="0" type="0" pos="-4 42.2469 14.6005" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 42.2469 0 0 1 14.6005 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -1.2775 1.36752" />
                            <Vertex pos="2 -1.75312 0.361641" />
                            <Vertex pos="-2 -1.2775 1.36752" />
                            <Vertex pos="-2 -1.75312 0.361641" />
                            <Vertex pos="2 1.75313 -0.00560856" />
                            <Vertex pos="2 1.75313 -1.36752" />
                            <Vertex pos="-2 1.75313 -0.00560856" />
                            <Vertex pos="-2 1.75313 -1.36752" />
                        </Vertices>
                        <Face id="0" plane="0 -0.904033 0.427463 -1.73947" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.412727 -0.910855 421.328 0 0.125 0.139053" texRot="0" texScale="0.125 0.139053" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.412705 -0.910865 22.993 0 -0.903981 0.427572 712.237 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 224.398 0 0 -1 1971.13 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.412699 0.910868 -0.718406" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.910865 -0.412705 1143.3 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.442303 -0.896866 -0.451067" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.910865 -0.412705 1143.3 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -1.75313" album="" material="bm_grid_blank1" texgens="0 0 1 170.321 1 0 0 379.092 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="-4 41.9927 13.3944" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 41.9927 0 0 1 13.3944 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -1.49891 1.56772" />
                            <Vertex pos="2 -2.00734 0.578126" />
                            <Vertex pos="-2 -1.49891 1.56772" />
                            <Vertex pos="-2 -2.00734 0.578126" />
                            <Vertex pos="2 2.00734 -0.161437" />
                            <Vertex pos="2 2.00734 -1.56772" />
                            <Vertex pos="-2 2.00734 -0.161437" />
                            <Vertex pos="-2 2.00734 -1.56772" />
                        </Vertices>
                        <Face id="0" plane="0 -0.889472 0.45699 -2.04967" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.471388 -0.881926 155.519 0 0.125 0.139059" texRot="0" texScale="0.125 0.139059" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.44229 -0.896872 23.7772 0 -0.889516 0.456904 702.309 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 256.938 0 0 -1 2125.51 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.442302 0.896866 -0.743064" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.896872 -0.44229 1153.21 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.471389 -0.881925 -0.436374" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.896872 -0.44229 1153.21 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -2.00734" album="" material="bm_grid_blank1" texgens="0 0 1 174.503 1 0 0 378.842 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="-4 41.7223 12.1713" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 41.7223 0 0 1 12.1713 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -1.73703 1.80128" />
                            <Vertex pos="2 -2.27766 0.828655" />
                            <Vertex pos="-2 -1.73703 1.80128" />
                            <Vertex pos="-2 -2.27766 0.828655" />
                            <Vertex pos="2 2.27766 -0.344563" />
                            <Vertex pos="2 2.27766 -1.80128" />
                            <Vertex pos="-2 2.27766 -0.344563" />
                            <Vertex pos="-2 2.27766 -1.80128" />
                        </Vertices>
                        <Face id="0" plane="0 -0.874049 0.485837 -2.39338" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.471388 -0.881926 433.131 0 0.125 0.139059" texRot="0" texScale="0.125 0.139059" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.471395 -0.881922 24.6337 0 -0.874085 0.485773 691.315 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 291.539 0 0 -1 2282.08 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.471388 0.881926 -0.769782" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.881922 -0.471395 1164.19 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.499989 -0.866032 -0.421162" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.881922 -0.471395 1164.19 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -2.27766" album="" material="bm_grid_blank1" texgens="0 0 1 177.411 1 0 0 378.612 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="0" type="0" pos="-4 41.4364 10.9288" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 41.4364 0 0 1 10.9288 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -1.99173 2.07119" />
                            <Vertex pos="2 -2.5636 1.11703" />
                            <Vertex pos="-2 -1.99173 2.07119" />
                            <Vertex pos="-2 -2.5636 1.11703" />
                            <Vertex pos="2 2.56359 -0.558753" />
                            <Vertex pos="2 2.56359 -2.07119" />
                            <Vertex pos="-2 2.56359 -0.558753" />
                            <Vertex pos="-2 2.56359 -2.07119" />
                        </Vertices>
                        <Face id="0" plane="0 -0.857741 0.514082 -2.77315" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.528064 -0.849205 162.757 0 0.125 0.139056" texRot="0" texScale="0.125 0.139056" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.500002 -0.866024 25.5327 0 -0.85773 0.514101 679.161 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 328.141 0 0 -1 2441.12 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.49999 0.866031 -0.797871" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.866025 -0.500002 1176.33 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.528059 -0.849207 -0.405142" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.866025 -0.500002 1176.33 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -2.56359" album="" material="bm_grid_blank1" texgens="0 0 1 178.895 1 0 0 378.409 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="0" type="0" pos="-4 41.135 9.6638" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 41.135 0 0 1 9.6638 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -2.26219 2.38199" />
                            <Vertex pos="2 -2.86501 1.44673" />
                            <Vertex pos="-2 -2.26219 2.38199" />
                            <Vertex pos="-2 -2.86501 1.44673" />
                            <Vertex pos="2 2.865 -0.806231" />
                            <Vertex pos="2 2.86499 -2.38199" />
                            <Vertex pos="-2 2.865 -0.806231" />
                            <Vertex pos="-2 2.86499 -2.38199" />
                        </Vertices>
                        <Face id="0" plane="0 -0.840531 0.541763 -3.19192" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.528064 -0.849205 446.5 0 0.125 0.139056" texRot="0" texScale="0.125 0.139056" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.528066 -0.849204 26.5031 0 -0.840463 0.541869 665.76 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 366.719 0 0 -1 2603.04 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.528059 0.849207 -0.828233" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.849204 -0.528066 1189.72 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.555576 -0.831466 -0.388824" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.849204 -0.528066 1189.72 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -6.35477e-006 -2.86501" album="" material="bm_grid_blank1" texgens="0 0 1 178.852 1 0 0 378.226 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="130" owner="0" type="0" pos="-4 40.8184 8.3733" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 40.8184 0 0 1 8.3733 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -2.54844 2.73723" />
                            <Vertex pos="2 -3.18156 1.82255" />
                            <Vertex pos="-2 -2.54844 2.73723" />
                            <Vertex pos="-2 -3.18156 1.82255" />
                            <Vertex pos="2 3.18156 -1.09149" />
                            <Vertex pos="2 3.18156 -2.73723" />
                            <Vertex pos="-2 3.18156 -1.09149" />
                            <Vertex pos="-2 3.18156 -2.73723" />
                        </Vertices>
                        <Face id="0" plane="0 -0.822243 0.569137 -3.6533" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.58246 -0.81286 170.505 0 0.125 0.139058" texRot="0" texScale="0.125 0.139058" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.555572 -0.831469 27.5211 0 -0.82226 0.569112 650.993 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 407.242 0 0 -1 2768.22 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.555576 0.831466 -0.860061" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.831468 -0.555572 1204.47 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.58248 -0.812845 -0.371746" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.831468 -0.555572 1204.47 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -3.18156" album="" material="bm_grid_blank1" texgens="0 0 1 177.101 1 0 0 378.07 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="131" owner="0" type="0" pos="-4 40.487 7.05326" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 40.487 0 0 1 7.05326 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -2.85016 3.14255" />
                            <Vertex pos="-2 -2.85016 3.14255" />
                            <Vertex pos="2 -3.51297 2.24874" />
                            <Vertex pos="-2 -3.51297 2.24874" />
                            <Vertex pos="2 3.51297 -1.41721" />
                            <Vertex pos="-2 3.51297 -1.41721" />
                            <Vertex pos="2 3.51297 -3.14255" />
                            <Vertex pos="-2 3.51297 -3.14255" />
                        </Vertices>
                        <Face id="0" plane="0 -0.803244 0.59565 -4.16123" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.58246 -0.81286 461.819 0 0.125 0.139058" texRot="0" texScale="0.125 0.139058" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 0.582478 0.812846 -0.894254" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.812848 -0.582476 1220.71 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.582476 -0.812848 28.6155 0 -0.803207 0.595701 634.74 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 449.656 0 0 -1 2937.18 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 -0.608768 -0.793348 -0.354551" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.812848 -0.582476 1220.71 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -3.51297" album="" material="bm_grid_blank1" texgens="0 0 1 211.504 1 0 0 1477.59 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="132" owner="0" type="0" pos="-4 40.1413 5.69953" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 40.1413 0 0 1 5.69953 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -3.16719 3.60247" />
                            <Vertex pos="2 -3.85875 2.73116" />
                            <Vertex pos="-2 -3.16719 3.60247" />
                            <Vertex pos="-2 -3.85875 2.73116" />
                            <Vertex pos="2 3.85875 -1.78881" />
                            <Vertex pos="2 3.85875 -3.60247" />
                            <Vertex pos="-2 3.85875 -1.78881" />
                            <Vertex pos="-2 3.85875 -3.60247" />
                        </Vertices>
                        <Face id="0" plane="0 -0.78327 0.621682 -4.72036" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.634418 -0.772991 178.41 0 0.125 0.139057" texRot="0" texScale="0.125 0.139057" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.608764 -0.793352 29.757 0 -0.783285 0.621663 616.847 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 493.922 0 0 -1 3110.46 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.608768 0.793349 -0.929932" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.793351 -0.608764 1238.59 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.634396 -0.773008 -0.336765" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.793351 -0.608764 1238.59 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -3.85875" album="" material="bm_grid_blank1" texgens="0 0 1 167.873 1 0 0 377.831 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="133" owner="0" type="0" pos="-4 39.7812 4.30666" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 39.7812 0 0 1 4.30666 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -3.49874 4.12403" />
                            <Vertex pos="2 -4.21874 3.2755" />
                            <Vertex pos="-2 -3.49874 4.12403" />
                            <Vertex pos="-2 -4.21874 3.2755" />
                            <Vertex pos="2 4.21874 -2.20958" />
                            <Vertex pos="2 4.21874 -4.12403" />
                            <Vertex pos="-2 4.21874 -2.20958" />
                            <Vertex pos="-2 4.21874 -4.12403" />
                        </Vertices>
                        <Face id="0" plane="0 -0.762493 0.646996 -5.336" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.634418 -0.772991 478.745 0 0.125 0.139057" texRot="0" texScale="0.125 0.139057" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.634391 -0.773012 30.9861 0 -0.76253 0.646953 597.148 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 540 0 0 -1 3288.75 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.634396 0.773009 -0.968326" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.773012 -0.634391 1258.27 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.659349 -0.751837 -0.318978" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.773012 -0.634391 1258.27 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -4.21874" album="" material="bm_grid_blank1" texgens="0 0 1 160.008 1 0 0 377.749 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="134" owner="0" type="0" pos="-4 39.4077 2.86889" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 39.4077 0 0 1 2.86889 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -3.84515 4.71327" />
                            <Vertex pos="2 -4.59234 3.88902" />
                            <Vertex pos="-2 -3.84515 4.71327" />
                            <Vertex pos="-2 -4.59234 3.88902" />
                            <Vertex pos="2 4.59235 -2.68627" />
                            <Vertex pos="2 4.59235 -4.71327" />
                            <Vertex pos="-2 4.59235 -2.68627" />
                            <Vertex pos="-2 4.59235 -4.71327" />
                        </Vertices>
                        <Face id="0" plane="0 -0.740892 0.671625 -6.01439" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.68358 -0.729876 186.717 0 0.125 0.139055" texRot="0" texScale="0.125 0.139055" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 -0.659348 -0.751838 32.2654 0 -0.740955 0.671555 575.444 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 587.82 0 0 -1 3472.78 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.659348 0.751838 -1.00832" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.751838 -0.659348 1279.96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.683588 -0.729868 -0.300794" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.751838 -0.659348 1279.96 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -4.59235" album="" material="bm_grid_blank1" texgens="0 0 1 149.659 1 0 0 377.698 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="135" owner="0" type="0" pos="-4 39.0208 1.3788" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 39.0208 0 0 1 1.3788 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -4.97922 4.57948" />
                            <Vertex pos="-2 -4.97922 4.57948" />
                            <Vertex pos="2 -4.20547 5.37911" />
                            <Vertex pos="-2 -4.20547 5.37911" />
                            <Vertex pos="2 4.97922 -5.37911" />
                            <Vertex pos="-2 4.97922 -5.37911" />
                            <Vertex pos="2 4.97922 -3.22318" />
                            <Vertex pos="-2 4.97922 -3.22318" />
                        </Vertices>
                        <Face id="0" plane="0 -0.71864 0.695382 -6.76276" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -0.68358 -0.729876 497.945 0 0.125 0.139055" texRot="0" texScale="0.125 0.139055" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.707112 -0.707101 -0.28271" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.729865 -0.683591 1303.89 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="1 0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -0.683591 -0.729865 33.6411 0 -0.718576 0.695449 551.493 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="-1 0 -0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 637.344 0 0 -1 3663.52 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 0.683588 0.729868 -1.05124" album="" material="bm_grid_blank1" texgens="-1 0 0 63.9999 0 0.729865 -0.683591 1303.89 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="0 1 0 -4.97922" album="" material="bm_grid_blank1" texgens="0 0 1 136.584 1 0 0 377.669 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="138" owner="0" type="0" pos="2 -2.25 1.75" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -2.25 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 0 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="139" owner="0" type="0" pos="12 1.75 3.75" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 1.75 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="140" owner="0" type="0" pos="8 1.75 3.25" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 1.75 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.75" />
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 -0.25 0.75" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 0.25 -0.75" />
                            <Vertex pos="-2 -0.25 -0.25" />
                            <Vertex pos="-2 -0.25 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_edge_white" texgens="1 0 0 640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="141" owner="0" type="0" pos="16 1.75 9.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 1.75 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="142" owner="0" type="0" pos="20 1.75 10.25" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 1.75 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="143" owner="0" type="0" pos="18.25 1.75 9.5" rot="1 0 0 0" scale="" transform="1 0 0 18.25 0 1 0 1.75 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.5" />
                            <Vertex pos="0.25 0.25 -0.5" />
                            <Vertex pos="0.25 -0.25 0.5" />
                            <Vertex pos="0.25 -0.25 -0.5" />
                            <Vertex pos="-0.25 0.25 0.5" />
                            <Vertex pos="-0.25 0.25 -0.5" />
                            <Vertex pos="-0.25 -0.25 0.5" />
                            <Vertex pos="-0.25 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="144" owner="0" type="0" pos="14.25 1.75 6.25" rot="1 0 0 0" scale="" transform="1 0 0 14.25 0 1 0 1.75 0 0 1 6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2.75" />
                            <Vertex pos="0.25 0.25 -2.75" />
                            <Vertex pos="0.25 -0.25 2.75" />
                            <Vertex pos="0.25 -0.25 -2.75" />
                            <Vertex pos="-0.25 0.25 2.75" />
                            <Vertex pos="-0.25 0.25 -2.75" />
                            <Vertex pos="-0.25 -0.25 2.75" />
                            <Vertex pos="-0.25 -0.25 -2.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2.75" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.75" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="145" owner="0" type="0" pos="22.25 4.75 10.25" rot="1 0 0 0" scale="" transform="1 0 0 22.25 0 1 0 4.75 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.25 0.25" />
                            <Vertex pos="0.25 3.25 -0.25" />
                            <Vertex pos="0.25 -3.25 0.25" />
                            <Vertex pos="0.25 -3.25 -0.25" />
                            <Vertex pos="-0.25 3.25 0.25" />
                            <Vertex pos="-0.25 3.25 -0.25" />
                            <Vertex pos="-0.25 -3.25 0.25" />
                            <Vertex pos="-0.25 -3.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 832 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -704 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="146" owner="0" type="0" pos="22.25 12.25 7.75" rot="1 0 0 0" scale="" transform="1 0 0 22.25 0 1 0 12.25 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.25 0.25" />
                            <Vertex pos="0.25 2.25 -0.25" />
                            <Vertex pos="0.25 -2.25 0.25" />
                            <Vertex pos="0.25 -2.25 -0.25" />
                            <Vertex pos="-0.25 2.25 0.25" />
                            <Vertex pos="-0.25 2.25 -0.25" />
                            <Vertex pos="-0.25 -2.25 0.25" />
                            <Vertex pos="-0.25 -2.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 576 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -448 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="147" owner="0" type="0" pos="20.25 9.75 7.75" rot="1 0 0 0" scale="" transform="1 0 0 20.25 0 1 0 9.75 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 0.25 0.25" />
                            <Vertex pos="2.25 0.25 -0.25" />
                            <Vertex pos="2.25 -0.25 0.25" />
                            <Vertex pos="2.25 -0.25 -0.25" />
                            <Vertex pos="-2.25 0.25 0.25" />
                            <Vertex pos="-2.25 0.25 -0.25" />
                            <Vertex pos="-2.25 -0.25 0.25" />
                            <Vertex pos="-2.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -576 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 704 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 704 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -576 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="148" owner="0" type="0" pos="22.25 16 8.25" rot="1 0 0 0" scale="" transform="1 0 0 22.25 0 1 0 16 0 0 1 8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="149" owner="0" type="0" pos="22.25 22 19.75" rot="1 0 0 0" scale="" transform="1 0 0 22.25 0 1 0 22 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1024 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="150" owner="0" type="0" pos="22.25 18.25 13.75" rot="1 0 0 0" scale="" transform="1 0 0 22.25 0 1 0 18.25 0 0 1 13.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 5.75" />
                            <Vertex pos="0.25 0.25 -5.75" />
                            <Vertex pos="0.25 -0.25 5.75" />
                            <Vertex pos="0.25 -0.25 -5.75" />
                            <Vertex pos="-0.25 0.25 5.75" />
                            <Vertex pos="-0.25 0.25 -5.75" />
                            <Vertex pos="-0.25 -0.25 5.75" />
                            <Vertex pos="-0.25 -0.25 -5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 2880 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5.75" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5.75" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="151" owner="0" type="0" pos="22.25 26.25 24.5" rot="1 0 0 0" scale="" transform="1 0 0 22.25 0 1 0 26.25 0 0 1 24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 5" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 -0.25 5" />
                            <Vertex pos="0.25 -0.25 -5" />
                            <Vertex pos="-0.25 0.25 5" />
                            <Vertex pos="-0.25 0.25 -5" />
                            <Vertex pos="-0.25 -0.25 5" />
                            <Vertex pos="-0.25 -0.25 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="152" owner="0" type="0" pos="22.25 30 29.75" rot="1 0 0 0" scale="" transform="1 0 0 22.25 0 1 0 30 0 0 1 29.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1024 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="153" owner="0" type="0" pos="22.25 34.25 31.5" rot="1 0 0 0" scale="" transform="1 0 0 22.25 0 1 0 34.25 0 0 1 31.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="154" owner="0" type="0" pos="22.25 36 33.75" rot="1 0 0 0" scale="" transform="1 0 0 22.25 0 1 0 36 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1408 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="155" owner="0" type="0" pos="22.25 39 34.25" rot="1 0 0 0" scale="" transform="1 0 0 22.25 0 1 0 39 0 0 1 34.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.75" />
                            <Vertex pos="0.25 1 0.25" />
                            <Vertex pos="0.25 -1 -0.250004" />
                            <Vertex pos="0.25 -1 -0.75" />
                            <Vertex pos="-0.25 1 0.75" />
                            <Vertex pos="-0.25 1 0.25" />
                            <Vertex pos="-0.25 -1 -0.250004" />
                            <Vertex pos="-0.25 -1 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -128 0 0.5 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1664 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447215 0.894427 -0.223605" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.223607" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="6.25 -0.5 1.75" rot="1 0 0 0" scale="" transform="1 0 0 6.25 0 1 0 -0.5 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1152 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1024 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="6.25 1.75 2.0625" rot="1 0 0 0" scale="" transform="1 0 0 6.25 0 1 0 1.75 0 0 1 2.0625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.5625" />
                            <Vertex pos="0.25 0.25 -0.5625" />
                            <Vertex pos="0.25 -0.25 0.5625" />
                            <Vertex pos="0.25 -0.25 -0.5625" />
                            <Vertex pos="-0.25 0.25 0.4375" />
                            <Vertex pos="-0.25 0.25 -0.5625" />
                            <Vertex pos="-0.25 -0.25 0.4375" />
                            <Vertex pos="-0.25 -0.25 -0.5625" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 1392 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 1392 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 1392 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 1392 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.485071" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5625" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="158" owner="0" type="0" pos="-6.25 4 -4.25" rot="1 0 0 0" scale="" transform="1 0 0 -6.25 0 1 0 4 0 0 1 -4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="159" owner="0" type="0" pos="-6.25 46 39.75" rot="1 0 0 0" scale="" transform="1 0 0 -6.25 0 1 0 46 0 0 1 39.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1152 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1024 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="160" owner="0" type="0" pos="-2 48.25 39.75" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 48.25 0 0 1 39.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.25 0.25" />
                            <Vertex pos="4.5 0.25 -0.25" />
                            <Vertex pos="4.5 -0.25 0.25" />
                            <Vertex pos="4.5 -0.25 -0.25" />
                            <Vertex pos="-4.5 0.25 0.25" />
                            <Vertex pos="-4.5 0.25 -0.25" />
                            <Vertex pos="-4.5 -0.25 0.25" />
                            <Vertex pos="-4.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_edge_white" texgens="0 1 0 704 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.5" album="" material="bm_edge_white" texgens="0 -1 0 -576 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 -1 0 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="161" owner="0" type="0" pos="-6.25 44.25 34.75" rot="1 0 0 0" scale="" transform="1 0 0 -6.25 0 1 0 44.25 0 0 1 34.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 4.75" />
                            <Vertex pos="0.25 0.25 -4.75" />
                            <Vertex pos="0.25 -0.25 4.75" />
                            <Vertex pos="0.25 -0.25 -4.75" />
                            <Vertex pos="-0.25 0.25 4.75" />
                            <Vertex pos="-0.25 0.25 -4.75" />
                            <Vertex pos="-0.25 -0.25 4.75" />
                            <Vertex pos="-0.25 -0.25 -4.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4.75" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="0" type="0" pos="-2.25 8 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 8 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1152 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1024 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="163" owner="0" type="0" pos="-2.25 12 4.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 12 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 1.25" />
                            <Vertex pos="0.25 2 0.75" />
                            <Vertex pos="0.25 -2 -0.75" />
                            <Vertex pos="0.25 -2 -1.25" />
                            <Vertex pos="-0.25 2 1.25" />
                            <Vertex pos="-0.25 2 0.75" />
                            <Vertex pos="-0.25 -2 -0.75" />
                            <Vertex pos="-0.25 -2 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1152 0 0 -1 1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0.5 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.223607" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.223607" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="164" owner="0" type="0" pos="-2.25 16 5.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 16 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1152 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1024 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="165" owner="0" type="0" pos="-2.25 16 14.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 16 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1152 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1024 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="167" owner="0" type="0" pos="-4.25 26 19.75" rot="1 0 0 0" scale="" transform="1 0 0 -4.25 0 1 0 26 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -7.5 0.25" />
                            <Vertex pos="0.25 -7.5 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -7.5 0.25" />
                            <Vertex pos="-0.25 -7.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1664 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1536 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7.5" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="168" owner="0" type="0" pos="-4.25 28 23.75" rot="1 0 0 0" scale="" transform="1 0 0 -4.25 0 1 0 28 0 0 1 23.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="169" owner="0" type="0" pos="-3 28 26.25" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 28 0 0 1 26.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.25" />
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -2 0.25" />
                            <Vertex pos="-1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 128 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 -128 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_tile08_C" texgens="-1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="170" owner="0" type="0" pos="-4.25 28 26.25" rot="1 0 0 0" scale="" transform="1 0 0 -4.25 0 1 0 28 0 0 1 26.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="171" owner="0" type="0" pos="-4.25 25.75 24.75" rot="1 0 0 0" scale="" transform="1 0 0 -4.25 0 1 0 25.75 0 0 1 24.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1.75" />
                            <Vertex pos="0.25 0.25 -1.25" />
                            <Vertex pos="0.25 -0.25 1.75" />
                            <Vertex pos="0.25 -0.25 -1.25" />
                            <Vertex pos="-0.25 0.25 1.75" />
                            <Vertex pos="-0.25 0.25 -1.25" />
                            <Vertex pos="-0.25 -0.25 1.75" />
                            <Vertex pos="-0.25 -0.25 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2624 0 0 -1 1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2496 0 0 -1 1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="172" owner="0" type="0" pos="-3.25 25.75 24.75" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 25.75 0 0 1 24.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.25 0.25 1.25" />
                            <Vertex pos="1.25 0.25 -0.75" />
                            <Vertex pos="1.25 -0.25 1.25" />
                            <Vertex pos="1.25 -0.25 -0.75" />
                            <Vertex pos="-0.75 0.25 1.25" />
                            <Vertex pos="-0.75 0.25 -0.75" />
                            <Vertex pos="-0.75 -0.25 1.25" />
                            <Vertex pos="-0.75 -0.25 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.25" album="" material="bm_edge_white" texgens="0 1 0 2624 0 0 -1 1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.75" album="" material="bm_edge_white" texgens="0 -1 0 -2496 0 0 -1 1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_friction_sand" texgens="-1 0 0 160 0 0 -1 160 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_grid_blank1" texgens="1 0 0 96 0 0 -1 160 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.25" album="" material="bm_edge_white" texgens="1 0 0 320 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.75" album="" material="bm_edge_white" texgens="-1 0 0 -192 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="173" owner="0" type="0" pos="-3.25 25.75 23.75" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 25.75 0 0 1 23.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.25 0.25 0.25" />
                            <Vertex pos="1.25 0.25 -0.25" />
                            <Vertex pos="1.25 -0.25 0.25" />
                            <Vertex pos="1.25 -0.25 -0.25" />
                            <Vertex pos="-0.75 0.25 0.25" />
                            <Vertex pos="-0.75 0.25 -0.25" />
                            <Vertex pos="-0.75 -0.25 0.25" />
                            <Vertex pos="-0.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.25" album="" material="bm_edge_white" texgens="0 1 0 2624 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.75" album="" material="bm_edge_white" texgens="0 -1 0 -2496 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 320 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 320 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -192 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="174" owner="0" type="0" pos="-3.25 25.75 26.25" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 25.75 0 0 1 26.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.25 0.25 0.25" />
                            <Vertex pos="1.25 0.25 -0.25" />
                            <Vertex pos="1.25 -0.25 0.25" />
                            <Vertex pos="1.25 -0.25 -0.25" />
                            <Vertex pos="-0.75 0.25 0.25" />
                            <Vertex pos="-0.75 0.25 -0.25" />
                            <Vertex pos="-0.75 -0.25 0.25" />
                            <Vertex pos="-0.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.25" album="" material="bm_edge_white" texgens="0 1 0 2624 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.75" album="" material="bm_edge_white" texgens="0 -1 0 -2496 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 320 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 320 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -192 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="176" owner="0" type="0" pos="-4.25 36 32.75" rot="1 0 0 0" scale="" transform="1 0 0 -4.25 0 1 0 36 0 0 1 32.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="177" owner="0" type="0" pos="-4.25 32 32.25" rot="1 0 0 0" scale="" transform="1 0 0 -4.25 0 1 0 32 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.75" />
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="0.25 -2 -0.75" />
                            <Vertex pos="-0.25 2 0.75" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                            <Vertex pos="-0.25 -2 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0.25 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242536" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.242536" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="178" owner="0" type="0" pos="-3.25 38.25 32.75" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 38.25 0 0 1 32.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.25 0.25 0.25" />
                            <Vertex pos="1.25 0.25 -0.25" />
                            <Vertex pos="1.25 -0.25 0.25" />
                            <Vertex pos="1.25 -0.25 -0.25" />
                            <Vertex pos="-1.25 0.25 0.25" />
                            <Vertex pos="-1.25 0.25 -0.25" />
                            <Vertex pos="-1.25 -0.25 0.25" />
                            <Vertex pos="-1.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.25" album="" material="bm_edge_white" texgens="0 1 0 2624 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.25" album="" material="bm_edge_white" texgens="0 -1 0 -2496 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="179" owner="0" type="0" pos="-2.25 18.25 9" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 18.25 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 3.5" />
                            <Vertex pos="0.25 0.25 -3.5" />
                            <Vertex pos="0.25 -0.25 3.5" />
                            <Vertex pos="0.25 -0.25 -3.5" />
                            <Vertex pos="-0.25 0.25 3.5" />
                            <Vertex pos="-0.25 0.25 -3.5" />
                            <Vertex pos="-0.25 -0.25 3.5" />
                            <Vertex pos="-0.25 -0.25 -3.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.5" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3.5" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="180" owner="0" type="0" pos="-3.5 21.75 19.75" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 21.75 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -3.25 0.25" />
                            <Vertex pos="1.5 -3.25 -0.25" />
                            <Vertex pos="1.5 -3.75 0.25" />
                            <Vertex pos="1.5 -3.75 -0.25" />
                            <Vertex pos="-1 -3.25 0.25" />
                            <Vertex pos="-1 -3.25 -0.25" />
                            <Vertex pos="-1 -3.75 0.25" />
                            <Vertex pos="-1 -3.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_edge_white" texgens="0 1 0 2624 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -2496 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.75" album="" material="bm_edge_white" texgens="1 0 0 256 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 256 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="181" owner="0" type="0" pos="-2.25 6.25 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 6.25 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.75" />
                            <Vertex pos="0.25 0.25 -0.75" />
                            <Vertex pos="0.25 -0.25 0.75" />
                            <Vertex pos="0.25 -0.25 -0.75" />
                            <Vertex pos="-0.25 0.25 0.75" />
                            <Vertex pos="-0.25 0.25 -0.75" />
                            <Vertex pos="-0.25 -0.25 0.75" />
                            <Vertex pos="-0.25 -0.25 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.75" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="182" owner="0" type="0" pos="-2.25 16 12.25" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 16 0 0 1 12.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1152 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1024 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="183" owner="0" type="0" pos="-2.25 18.25 17" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 18.25 0 0 1 17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2.5" />
                            <Vertex pos="0.25 0.25 -2.5" />
                            <Vertex pos="0.25 -0.25 2.5" />
                            <Vertex pos="0.25 -0.25 -2.5" />
                            <Vertex pos="-0.25 0.25 2.5" />
                            <Vertex pos="-0.25 0.25 -2.5" />
                            <Vertex pos="-0.25 -0.25 2.5" />
                            <Vertex pos="-0.25 -0.25 -2.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2.5" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.5" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="184" owner="0" type="0" pos="-2.25 14.25 13.5" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 14.25 0 0 1 13.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="185" owner="0" type="0" pos="-2.25 39 37.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 39 0 0 1 37.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.25" />
                            <Vertex pos="0.25 1 -0.25" />
                            <Vertex pos="0.25 -1 0.25" />
                            <Vertex pos="0.25 -1 -0.25" />
                            <Vertex pos="-0.25 1 0.25" />
                            <Vertex pos="-0.25 1 -0.25" />
                            <Vertex pos="-0.25 -1 0.25" />
                            <Vertex pos="-0.25 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1920 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="186" owner="0" type="0" pos="-2.25 42 38.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 42 0 0 1 38.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 1.25" />
                            <Vertex pos="0.25 2 0.749996" />
                            <Vertex pos="0.25 -2 -0.750004" />
                            <Vertex pos="0.25 -2 -1.25" />
                            <Vertex pos="-0.25 2 1.25" />
                            <Vertex pos="-0.25 2 0.749996" />
                            <Vertex pos="-0.25 -2 -0.750004" />
                            <Vertex pos="-0.25 -2 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0.5 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.223605" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447213 -0.894428 -0.223609" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="187" owner="0" type="0" pos="-2.25 38.25 35.25" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 38.25 0 0 1 35.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2.25" />
                            <Vertex pos="0.25 0.25 -2.25" />
                            <Vertex pos="0.25 -0.25 2.25" />
                            <Vertex pos="0.25 -0.25 -2.25" />
                            <Vertex pos="-0.25 0.25 2.25" />
                            <Vertex pos="-0.25 0.25 -2.25" />
                            <Vertex pos="-0.25 -0.25 2.25" />
                            <Vertex pos="-0.25 -0.25 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2624 0 0 -1 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2496 0 0 -1 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -320 0 0 -1 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 448 0 0 -1 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2.25" album="" material="bm_edge_white" texgens="1 0 0 448 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.25" album="" material="bm_edge_white" texgens="-1 0 0 -320 0 -1 0 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="190" owner="0" type="0" pos="-2.25 2.25 1.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.25 0 1 0 2.25 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.25 0.25" />
                            <Vertex pos="0.25 4.25 -0.25" />
                            <Vertex pos="0.25 -4.75 0.25" />
                            <Vertex pos="0.25 -4.75 -0.25" />
                            <Vertex pos="-0.25 4.25 0.25" />
                            <Vertex pos="-0.25 4.25 -0.25" />
                            <Vertex pos="-0.25 -4.75 0.25" />
                            <Vertex pos="-0.25 -4.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 576 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -448 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.75" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="191" owner="0" type="0" pos="22.25 40.25 34.75" rot="1 0 0 0" scale="" transform="1 0 0 22.25 0 1 0 40.25 0 0 1 34.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 0.25" />
                            <Vertex pos="0.25 0.25 -0.25" />
                            <Vertex pos="0.25 -0.25 0.25" />
                            <Vertex pos="0.25 -0.25 -0.25" />
                            <Vertex pos="-0.25 0.25 0.25" />
                            <Vertex pos="-0.25 0.25 -0.25" />
                            <Vertex pos="-0.25 -0.25 0.25" />
                            <Vertex pos="-0.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1984 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1856 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -1856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -1856 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="192" owner="0" type="0" pos="11 22 -6" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 22 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 6" />
                            <Vertex pos="1 4 0" />
                            <Vertex pos="1 -4 6" />
                            <Vertex pos="1 -4 0" />
                            <Vertex pos="-1 4 6" />
                            <Vertex pos="-1 4 0" />
                            <Vertex pos="-1 -4 6" />
                            <Vertex pos="-1 -4 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 768 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -768 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_tile11_C" texgens="1 0 0 256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="318" owner="13" type="999" pos="1 36 35" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 36 0 0 1 35 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1" />
                            <Vertex pos="1 2 -1" />
                            <Vertex pos="1 0 1" />
                            <Vertex pos="1 0 -1" />
                            <Vertex pos="-1 2 1" />
                            <Vertex pos="-1 2 -1" />
                            <Vertex pos="-1 0 1" />
                            <Vertex pos="-1 0 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_basher_side" texgens="0 1 0 0 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_basher_side" texgens="0 -1 0 512 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_basher" texgens="-1 0 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_basher" texgens="1 0 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_basher_top" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_basher_top" texgens="-1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="319" owner="17" type="999" pos="19 34 35" rot="1 0 0 0" scale="" transform="1 0 0 19 0 1 0 34 0 0 1 35 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1" />
                            <Vertex pos="1 2 -1" />
                            <Vertex pos="1 0 1" />
                            <Vertex pos="1 0 -1" />
                            <Vertex pos="-1 2 1" />
                            <Vertex pos="-1 2 -1" />
                            <Vertex pos="-1 0 1" />
                            <Vertex pos="-1 0 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_basher_side" texgens="0 1 0 0 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_basher_side" texgens="0 -1 0 512 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_basher" texgens="-1 0 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_basher" texgens="1 0 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_basher_top" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_basher_top" texgens="-1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="320" owner="0" type="0" pos="20 21 -8" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 21 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -11 -6" />
                            <Vertex pos="2 -11 -18" />
                            <Vertex pos="2 -15 -6" />
                            <Vertex pos="2 -15 -18" />
                            <Vertex pos="-2 -11 -6" />
                            <Vertex pos="-2 -11 -18" />
                            <Vertex pos="-2 -15 -6" />
                            <Vertex pos="-2 -15 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 2688 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -2688 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 11" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -15" album="" material="bm_grid_blank1" texgens="1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -1 0 -4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 -2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="321" owner="0" type="0" pos="12 17 -8" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 17 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 -2" />
                            <Vertex pos="2 1 -18" />
                            <Vertex pos="2 -15 0" />
                            <Vertex pos="2 -15 -18" />
                            <Vertex pos="-2 1 -2" />
                            <Vertex pos="-2 1 -18" />
                            <Vertex pos="-2 -15 0" />
                            <Vertex pos="-2 -15 -18" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 2688 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -2688 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -15" album="" material="bm_grid_blank1" texgens="1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.124035 0.992278 1.86052" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -1 0 3840 180 0.125 0.125" texRot="180" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 -2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="322" owner="0" type="0" pos="20 29 -8" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 29 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -7 -4" />
                            <Vertex pos="2 -7 -18" />
                            <Vertex pos="2 -11 -4" />
                            <Vertex pos="2 -11 -18" />
                            <Vertex pos="-6 -7 -2" />
                            <Vertex pos="-6 -7 -18" />
                            <Vertex pos="-6 -11 -2" />
                            <Vertex pos="-6 -11 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 2688 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank1" texgens="0 -1 0 -2688 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 7" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -11" album="" material="bm_grid_blank1" texgens="1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 3.3955" album="" material="bm_friction_ice" texgens="1 0 0 -1024 0 -1 0 3840 180 0.125 0.125" texRot="180" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 -2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="323" owner="0" type="0" pos="12 29 -8" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 29 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -7 -2" />
                            <Vertex pos="2 -7 -18" />
                            <Vertex pos="2 -11 -2" />
                            <Vertex pos="2 -11 -18" />
                            <Vertex pos="-2 -7 -2" />
                            <Vertex pos="-2 -7 -18" />
                            <Vertex pos="-2 -11 -2" />
                            <Vertex pos="-2 -11 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 2688 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -2688 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 7" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -11" album="" material="bm_grid_blank1" texgens="1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 2" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -1 0 3840 180 0.125 0.125" texRot="180" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 -2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="324" owner="0" type="0" pos="20 33 2" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 33 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -11 -6" />
                            <Vertex pos="2 -11 -10" />
                            <Vertex pos="2 -15 -6" />
                            <Vertex pos="2 -15 -10" />
                            <Vertex pos="-6 -11 -6" />
                            <Vertex pos="-6 -11 -8" />
                            <Vertex pos="-6 -15 -6" />
                            <Vertex pos="-6 -15 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 2688 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank1" texgens="0 -1 0 -2688 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 11" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -15" album="" material="bm_grid_blank1" texgens="1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -1 0 -4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -9.21635" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 -2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="325" owner="0" type="0" pos="12 17 -2" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 17 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0" />
                            <Vertex pos="2 1 -4" />
                            <Vertex pos="2 -15 0" />
                            <Vertex pos="2 -15 -2" />
                            <Vertex pos="-2 1 0" />
                            <Vertex pos="-2 1 -4" />
                            <Vertex pos="-2 -15 0" />
                            <Vertex pos="-2 -15 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 2688 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -2688 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -15" album="" material="bm_grid_blank1" texgens="1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -1 0 -4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.124035 -0.992278 -3.84508" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 -2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="326" owner="0" type="0" pos="20 8 6.75" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 8 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 -12.75" />
                            <Vertex pos="2 2 -16.75" />
                            <Vertex pos="2 -2 -12.75" />
                            <Vertex pos="2 -2 -16.75" />
                            <Vertex pos="-2 2 -8.75" />
                            <Vertex pos="-2 2 -16.75" />
                            <Vertex pos="-2 -2 -8.75" />
                            <Vertex pos="-2 -2 -16.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 7.6014" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16.75" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="327" owner="0" type="0" pos="-6.25 4 -3.75" rot="1 0 0 0" scale="" transform="1 0 0 -6.25 0 1 0 4 0 0 1 -3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 3.75" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -6 3.75" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 2 3.75" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -6 3.75" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.75" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="328" owner="0" type="0" pos="-6.25 4 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -6.25 0 1 0 4 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="333" owner="0" type="0" pos="-6.25 6.25 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 -6.25 0 1 0 6.25 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -3.5" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -3.5" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -3.5" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -3.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 0 -1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 192 0 0 -1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 192 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3.5" album="" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="334" owner="12" type="4" pos="16 24 16.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 24 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 -2272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_C" texgens="1 0 0 0 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="335" owner="0" type="0" pos="16 4 -17.75" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 4 0 0 1 -17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 13.75" />
                            <Vertex pos="2 2 7.75" />
                            <Vertex pos="2 0 13.75" />
                            <Vertex pos="2 0 7.75" />
                            <Vertex pos="-2 2 13.75" />
                            <Vertex pos="-2 2 7.75" />
                            <Vertex pos="-2.5 0 13.75" />
                            <Vertex pos="-2.5 0 7.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970142 0.242536 0 -2.42536" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13.75" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 7.75" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="336" owner="0" type="0" pos="16 2 -17.75" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 2 0 0 1 -17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 13.75" />
                            <Vertex pos="2 2 7.75" />
                            <Vertex pos="2 0 13.75" />
                            <Vertex pos="2 0 7.75" />
                            <Vertex pos="-2.5 2 13.75" />
                            <Vertex pos="-2.5 2 7.75" />
                            <Vertex pos="-2 0 13.75" />
                            <Vertex pos="-2 0 7.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970142 -0.242536 0 -1.94028" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13.75" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 7.75" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="337" owner="0" type="0" pos="16 4 -23.75" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 4 0 0 1 -23.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 13.75" />
                            <Vertex pos="2 2 -2.25" />
                            <Vertex pos="2 -2 13.75" />
                            <Vertex pos="2 -2 -2.25" />
                            <Vertex pos="-2 2 13.75" />
                            <Vertex pos="-2 2 -2.25" />
                            <Vertex pos="-2 -2 13.75" />
                            <Vertex pos="-2 -2 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13.75" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.25" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="363" owner="0" type="0" pos="9.03407 20.5176 -8" rot="1 0 0 0" scale="" transform="1 0 0 9.03407 0 1 0 20.5176 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="51" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.03408 3.8147e-006 -2" />
                            <Vertex pos="0.965925 -0.517635 -2" />
                            <Vertex pos="0.965925 -0.517635 2" />
                            <Vertex pos="1.03408 3.8147e-006 2" />
                            <Vertex pos="0.965925 0.0182644 2" />
                            <Vertex pos="0.965925 0.0182644 -2" />
                        </Vertices>
                        <Face id="45" plane="0.991443 -0.130539 0 -1.02523" album="" material="bm_grid_blank1" texgens="0.707106 0.707107 0 -28.6907 0 0 -1 256 0 0.353554 0.25" texRot="0" texScale="0.353554 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="46" plane="0 0 1 -2" album="" material="bm_grid_blank1" texgens="0 1 0 16.5644 0.991446 -0.130519 0 30.6453 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4" />
                        </Face>
                        <Face id="47" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="0.0655382 0.995695 -0.0655407 14.4672 0.69804 -0.0918939 0.710138 67.0251 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 5 1" />
                        </Face>
                        <Face id="48" plane="0.258799 0.965931 0 -0.267623" album="" material="bm_grid_blank1" texgens="0 0 -1 64 -1 0 0 94.9096 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="49" plane="-1 -0 -0 0.965925" album="" material="bm_grid_blank1" texgens="0 1 0 16.5644 0 0 1 30.6453 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 2 1" />
                        </Face>
                    </Brush>
                    <Brush id="365" owner="0" type="0" pos="9.20212 21.2588 -8" rot="1 0 0 0" scale="" transform="1 0 0 9.20212 0 1 0 21.2588 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="52" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.06583 -0.258816 -2" />
                            <Vertex pos="0.86603 -0.741178 -2" />
                            <Vertex pos="0.86603 -0.741178 2" />
                            <Vertex pos="1.06583 -0.258816 2" />
                            <Vertex pos="0.79788 -0.722917 2" />
                            <Vertex pos="0.79788 -0.104116 2" />
                            <Vertex pos="0.79788 -0.104116 -2" />
                            <Vertex pos="0.79788 -0.722917 -2" />
                        </Vertices>
                        <Face id="45" plane="0.92388 -0.382682 0 -1.08374" album="" material="bm_grid_blank1" texgens="0.707106 0.707107 0 29.4998 0 0 -1 256 0 0.353554 0.25" texRot="0" texScale="0.353554 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="46" plane="0 -0 1 -2" album="" material="bm_grid_blank1" texgens="0.258817 0.965926 0 15.7369 0.923876 -0.382692 0 28.7727 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="47" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="0.321017 0.944802 -0.0655482 13.5122 0.650467 -0.269439 0.710138 65.7066 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="48" plane="-0.258822 -0.965925 0 -0.491775" album="" material="bm_grid_blank1" texgens="0 0 -1 64 -0.965926 0.258817 0 96.9071 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="49" plane="0.499998 0.866027 0 -0.308771" album="" material="bm_grid_blank1" texgens="0 0 -1 64 -0.965926 0.258817 0 96.9071 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="50" plane="-1 0 0 0.79788" album="" material="bm_grid_blank1" texgens="0 1 0 15.7369 0 0 1 28.7727 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="367" owner="0" type="0" pos="9.56084 21.9142 -8" rot="1 0 0 0" scale="" transform="1 0 0 9.56084 0 1 0 21.9142 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="52" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.02494 -0.5 -2" />
                            <Vertex pos="0.707105 -0.914212 -2" />
                            <Vertex pos="0.707105 -0.914212 2" />
                            <Vertex pos="1.02494 -0.5 2" />
                            <Vertex pos="0.439157 -0.759513 2" />
                            <Vertex pos="0.439157 0.0857847 2" />
                            <Vertex pos="0.439157 0.0857847 -2" />
                            <Vertex pos="0.439157 -0.759513 -2" />
                        </Vertices>
                        <Face id="45" plane="0.793354 -0.60876 0 -1.11752" album="" material="bm_grid_blank1" texgens="0.707106 0.707107 0 94.4033 0 0 -1 256 0 0.353554 0.25" texRot="0" texScale="0.353554 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="46" plane="0 -0 1 -2" album="" material="bm_grid_blank1" texgens="0.499998 0.866026 0 14.0218 0.793356 -0.608757 0 27.6917 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="47" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="0.554606 0.829528 -0.0655412 11.7183 0.558572 -0.428603 0.710138 64.9456 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="48" plane="-0.499998 -0.866027 0 -0.438181" album="" material="bm_grid_blank1" texgens="0 0 -1 64 -0.866026 0.499998 0 98.2232 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="49" plane="0.707108 0.707106 0 -0.37119" album="" material="bm_grid_blank1" texgens="0 0 -1 64 -0.866026 0.499998 0 98.2232 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="50" plane="-1 0 0 0.439157" album="" material="bm_grid_blank1" texgens="0 1 0 14.0218 0 0 1 27.6917 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="371" owner="0" type="0" pos="10.7412 22.7979 -8" rot="1 0 0 0" scale="" transform="1 0 0 10.7412 0 1 0 22.7979 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="52" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.741182 -0.866024 -2" />
                            <Vertex pos="0.258818 -1.06582 -2" />
                            <Vertex pos="0.258818 -1.06582 2" />
                            <Vertex pos="0.741182 -0.866024 2" />
                            <Vertex pos="0.104117 -0.797875 2" />
                            <Vertex pos="0.722922 -0.797875 2" />
                            <Vertex pos="0.722922 -0.797875 -2" />
                            <Vertex pos="0.104117 -0.797875 -2" />
                        </Vertices>
                        <Face id="45" plane="0.382674 -0.923883 0 -1.08374" album="" material="bm_grid_blank1" texgens="0.707106 0.707107 0 226.499 0 0 -1 256 0 0.353554 0.25" texRot="0" texScale="0.353554 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="46" plane="0 -0 1 -2" album="" material="bm_grid_blank1" texgens="0.866025 0.5 0 9.88064 0.38268 -0.923881 0 28.7728 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="47" plane="-0 -0 -1 -2" album="" material="bm_grid_blank1" texgens="0.895069 0.441084 -0.0655449 7.63068 0.269431 -0.65047 0.710138 65.7067 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="48" plane="-0.866021 -0.500007 0 -0.308776" album="" material="bm_grid_blank1" texgens="0 0 -1 64 -0.5 0.866025 0 97.6781 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="49" plane="0.965927 0.258813 0 -0.49179" album="" material="bm_grid_blank1" texgens="0 0 -1 64 -0.5 0.866025 0 97.6781 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="50" plane="0 1 -0 0.797875" album="" material="bm_grid_blank1" texgens="1 0 0 9.88064 0 0 1 28.7728 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="373" owner="0" type="0" pos="11.4824 22.9659 -8" rot="1 0 0 0" scale="" transform="1 0 0 11.4824 0 1 0 22.9659 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="51" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.517635 -0.965924 -2" />
                            <Vertex pos="-2.38419e-006 -1.03407 -2" />
                            <Vertex pos="-2.38419e-006 -1.03407 2" />
                            <Vertex pos="0.517635 -0.965924 2" />
                            <Vertex pos="-0.0182627 -0.965926 2" />
                            <Vertex pos="-0.0182626 -0.965926 -2" />
                        </Vertices>
                        <Face id="45" plane="0.130522 -0.991445 0 -1.02522" album="" material="bm_grid_blank1" texgens="0.707106 0.707107 0 284.69 0 0 -1 256 0 0.353554 0.25" texRot="0" texScale="0.353554 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="46" plane="0 -0 1 -2" album="" material="bm_grid_blank1" texgens="0.965926 0.258818 0 8.56445 0.13053 -0.991444 0 30.6451 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 4" />
                        </Face>
                        <Face id="47" plane="0 0 -1 -2" album="" material="bm_grid_blank1" texgens="0.978731 0.194396 -0.0655404 6.43271 0.091901 -0.698039 0.710138 67.0249 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 5 1" />
                        </Face>
                        <Face id="48" plane="-0.965922 -0.258833 -2.3839e-008 -0.267654" album="" material="bm_grid_blank1" texgens="0 0 -1 64 -0.258818 0.965926 0 95.9628 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 5 4 2" />
                        </Face>
                        <Face id="49" plane="-3.67039e-006 1 0 0.965926" album="" material="bm_grid_blank1" texgens="1 0 0 8.56445 0 0 1 30.6451 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 0 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="377" owner="0" type="0" pos="10.0858 22.4392 -8" rot="1 0 0 0" scale="" transform="1 0 0 10.0858 0 1 0 22.4392 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="58" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.914216 -0.707104 -2" />
                            <Vertex pos="0.500002 -1.02495 -2" />
                            <Vertex pos="0.500002 -1.02495 2" />
                            <Vertex pos="0.914216 -0.707104 2" />
                            <Vertex pos="-0.0857849 -0.439162 -2" />
                            <Vertex pos="-0.0857849 -0.439162 2" />
                            <Vertex pos="0.759514 -0.439153 2" />
                            <Vertex pos="0.759514 -0.439153 -2" />
                        </Vertices>
                        <Face id="51" plane="0.608772 -0.793346 0 -1.11753" album="" material="bm_grid_blank1" texgens="0.707106 0.707107 0 161.596 0 0 -1 256 0 0.353554 0.25" texRot="0" texScale="0.353554 0.25" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="52" plane="-0.707107 -0.707106 0 -0.371193" album="" material="bm_grid_blank1" texgens="0 0 -1 64 -0.707108 0.707106 0 98.5055 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="53" plane="0.866025 0.500001 0 -0.438181" album="" material="bm_grid_blank1" texgens="0 0 -1 64 -0.707108 0.707106 0 98.5055 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="54" plane="0 -0 1 -2" album="" material="bm_grid_blank1" texgens="0.707106 0.707108 0 11.8782 0.608763 -0.793352 0 27.6917 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="55" plane="0 -0 -1 -2" album="" material="bm_grid_blank1" texgens="0.750407 0.657718 -0.0655425 9.56546 0.428607 -0.558569 0.710138 64.9456 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="56" plane="-1.06475e-005 1 0 0.439161" album="" material="bm_grid_blank1" texgens="1 0 0 64 0 0 1 98.5055 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="394" owner="0" type="0" pos="-3 30.3414 26.2212" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 -3 0 1 0 30.3414 -1 0 5.96046e-008 26.2212 0 0 0 1" group="-1" locked="0" nextFaceID="24" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.27882 -0.341409 1" />
                            <Vertex pos="-0.21157 0.341409 1" />
                            <Vertex pos="0.22118 -0.341408 1" />
                            <Vertex pos="0.27882 0.243865 1" />
                            <Vertex pos="-0.27882 -0.341409 -1" />
                            <Vertex pos="-0.21157 0.341409 -1" />
                            <Vertex pos="0.22118 -0.341408 -1" />
                            <Vertex pos="0.27882 0.243865 -1" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_edge_white" texgens="0 1 0 10.9251 0.995185 -0.0980147 0 7.80846 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 -0 -1 -1" album="" material="bm_edge_white" texgens="0.0242126 0.998808 -0.0423765 9.77205 0.863033 -0.0849992 0.497946 22.7058 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="19" plane="-0.995185 0.0980147 0 -0.244014" album="" material="bm_grid_blank1" texgens="0 0 1 128 -0.382681 -0.923881 0 215.659 0 0.25 0.334849" texRot="0" texScale="0.25 0.334849" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="20" plane="1.96695e-006 -1 0 -0.341408" album="" material="bm_edge_white" texgens="0 0 -1 32 -1 0 0 103.078 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="21" plane="0.195089 0.980785 0 -0.293574" album="" material="bm_edge_white" texgens="0 0 -1 32 -1 0 0 103.078 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="22" plane="0.995185 -0.0980098 0 -0.253576" album="" material="bm_tile08_C" texgens="0 0 -1 256 -0.382683 -0.92388 0 460.54 0 0.125 0.143507" texRot="0" texScale="0.125 0.143507" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="395" owner="0" type="0" pos="-3 30.9623 26.1022" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 -3 0 1 0 30.9623 -1 0 5.96046e-008 26.1022 0 0 0 1" group="-1" locked="0" nextFaceID="24" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.330555 -0.279519 1" />
                            <Vertex pos="-0.131385 0.377062 1" />
                            <Vertex pos="0.159835 -0.377062 1" />
                            <Vertex pos="0.330555 0.185721 1" />
                            <Vertex pos="-0.330555 -0.279519 -1" />
                            <Vertex pos="-0.131385 0.377062 -1" />
                            <Vertex pos="0.159835 -0.377062 -1" />
                            <Vertex pos="0.330555 0.185721 -1" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_edge_white" texgens="0.195088 0.980786 0 10.8363 0.956941 -0.290282 0 7.52583 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 -0 -1 -1" album="" material="bm_edge_white" texgens="0.218606 0.974893 -0.0423763 9.67634 0.829867 -0.251735 0.497945 22.4607 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="19" plane="-0.956941 0.290282 0 -0.235182" album="" material="bm_grid_blank1" texgens="0 0 1 128 -0.382681 -0.923881 0 156.486 0 0.25 0.334849" texRot="0" texScale="0.25 0.334849" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="20" plane="-0.195087 -0.980786 0 -0.338635" album="" material="bm_edge_white" texgens="0 0 -1 32 -0.980786 0.195088 0 103.371 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="21" plane="0.382682 0.92388 0 -0.298081" album="" material="bm_edge_white" texgens="0 0 -1 32 -0.980786 0.195088 0 103.371 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="22" plane="0.95694 -0.290287 0 -0.262409" album="" material="bm_tile08_C" texgens="0 0 -1 256 -0.382683 -0.92388 0 322.468 0 0.125 0.143507" texRot="0" texScale="0.125 0.143507" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="396" owner="0" type="0" pos="-3 31.5463 25.864" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 -3 0 1 0 31.5463 -1 0 5.96046e-008 25.864 0 0 0 1" group="-1" locked="0" nextFaceID="24" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.369584 -0.206879 1" />
                            <Vertex pos="-0.0461533 0.398221 1" />
                            <Vertex pos="0.0923557 -0.398221 1" />
                            <Vertex pos="0.369584 0.120435 1" />
                            <Vertex pos="-0.369584 -0.206879 -1" />
                            <Vertex pos="-0.0461533 0.398221 -1" />
                            <Vertex pos="0.0923557 -0.398221 -1" />
                            <Vertex pos="0.369584 0.120435 -1" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_edge_white" texgens="0.382683 0.92388 0 10.6421 0.881923 -0.471394 0 7.30953 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 -0 -1 -1" album="" material="bm_edge_white" texgens="0.404598 0.913512 -0.0423754 9.47661 0.764811 -0.408797 0.497945 22.2731 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="19" plane="-0.881923 0.471395 0 -0.228423" album="" material="bm_grid_blank1" texgens="0 0 1 128 -0.382681 -0.923881 0 96.2177 0 0.25 0.334849" texRot="0" texScale="0.25 0.334849" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="20" plane="-0.382684 -0.923879 0 -0.332565" album="" material="bm_edge_white" texgens="0 0 -1 32 -0.92388 0.382683 0 103.607 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="21" plane="0.555569 0.83147 0 -0.305468" album="" material="bm_edge_white" texgens="0 0 -1 32 -0.92388 0.382683 0 103.607 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="22" plane="0.881921 -0.471398 0 -0.269171" album="" material="bm_tile08_C" texgens="0 0 -1 256 -0.382683 -0.92388 0 181.842 0 0.125 0.143507" texRot="0" texScale="0.125 0.143507" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="397" owner="0" type="0" pos="-3 32.0708 25.5157" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 -3 0 1 0 32.0708 -1 0 5.96046e-008 25.5157 0 0 0 1" group="-1" locked="0" nextFaceID="24" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.394413 -0.126298 1" />
                            <Vertex pos="0.0408571 0.404082 1" />
                            <Vertex pos="0.021323 -0.404082 1" />
                            <Vertex pos="0.394413 0.0505278 1" />
                            <Vertex pos="-0.394413 -0.126298 -1" />
                            <Vertex pos="0.0408571 0.404082 -1" />
                            <Vertex pos="0.021323 -0.404082 -1" />
                            <Vertex pos="0.394413 0.0505278 -1" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_edge_white" texgens="0.555568 0.831471 0 10.3724 0.773012 -0.634392 0 7.19241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 -0 -1 -1" album="" material="bm_edge_white" texgens="0.57504 0.817027 -0.0423767 9.2037 0.670362 -0.55015 0.497945 22.1716 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="19" plane="-0.773012 0.634392 0 -0.224763" album="" material="bm_grid_blank1" texgens="0 0 1 128 -0.382681 -0.923881 0 37.171 0 0.25 0.334849" texRot="0" texScale="0.25 0.334849" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="20" plane="-0.555568 -0.831471 0 -0.324136" album="" material="bm_edge_white" texgens="0 0 -1 32 -0.831471 0.555568 0 103.751 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="21" plane="0.707105 0.707108 0 -0.31462" album="" material="bm_edge_white" texgens="0 0 -1 32 -0.831471 0.555568 0 103.751 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="22" plane="0.773009 -0.634395 0 -0.27283" album="" material="bm_tile08_C" texgens="0 0 -1 256 -0.382683 -0.92388 0 44.0664 0 0.125 0.143507" texRot="0" texScale="0.125 0.143507" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="398" owner="0" type="0" pos="-3 32.5157 25.0708" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 -3 0 1 0 32.5157 -1 0 5.96046e-008 25.0708 0 0 0 1" group="-1" locked="0" nextFaceID="24" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.404083 -0.0408583 1" />
                            <Vertex pos="0.126297 0.394412 1" />
                            <Vertex pos="-0.0505276 -0.394412 1" />
                            <Vertex pos="0.404083 -0.0213215 1" />
                            <Vertex pos="-0.404083 -0.0408583 -1" />
                            <Vertex pos="0.126297 0.394412 -1" />
                            <Vertex pos="-0.0505276 -0.394412 -1" />
                            <Vertex pos="0.404083 -0.0213215 -1" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_edge_white" texgens="0.707105 0.707108 0 10.0679 0.634392 -0.773012 0 7.19241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 -0 -1 -1" album="" material="bm_edge_white" texgens="0.723386 0.689142 -0.0423782 8.89877 0.55015 -0.670362 0.497945 22.1716 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="19" plane="-0.634392 0.773011 0 -0.224763" album="" material="bm_grid_blank1" texgens="0 0 -1 128 0.92388 0.382683 0 37.1713 0 0.25 0.33485" texRot="0" texScale="0.25 0.33485" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="20" plane="-0.707105 -0.707108 0 -0.31462" album="" material="bm_edge_white" texgens="0 0 -1 32 -0.707108 0.707105 0 103.781 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="21" plane="0.831468 0.555573 0 -0.324136" album="" material="bm_edge_white" texgens="0 0 -1 32 -0.707108 0.707105 0 103.781 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="22" plane="0.634395 -0.773009 0 -0.27283" album="" material="bm_tile08_C" texgens="0 0 1 256 0.92388 0.382683 0 44.0659 0 0.125 0.143507" texRot="0" texScale="0.125 0.143507" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="399" owner="0" type="0" pos="-3 32.864 24.5463" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 -3 0 1 0 32.864 -1 0 5.96046e-008 24.5463 0 0 0 1" group="-1" locked="0" nextFaceID="24" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.398226 0.0461466 1" />
                            <Vertex pos="0.206884 0.369586 1" />
                            <Vertex pos="-0.120441 -0.369586 1" />
                            <Vertex pos="0.398226 -0.0923529 1" />
                            <Vertex pos="-0.398226 0.0461466 -1" />
                            <Vertex pos="0.206884 0.369586 -1" />
                            <Vertex pos="-0.120441 -0.369586 -1" />
                            <Vertex pos="0.398226 -0.0923529 -1" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_edge_white" texgens="0.831469 0.555572 0 9.77518 0.471399 -0.88192 0 7.30946 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 -0 -1 -1" album="" material="bm_edge_white" texgens="0.843931 0.534775 -0.0423759 8.60867 0.408801 -0.764808 0.497945 22.2731 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="19" plane="-0.471398 0.88192 0 -0.228421" album="" material="bm_grid_blank1" texgens="0 0 -1 128 0.92388 0.382683 0 96.218 0 0.25 0.33485" texRot="0" texScale="0.25 0.33485" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="20" plane="-0.831468 -0.555572 0 -0.305475" album="" material="bm_edge_white" texgens="0 0 -1 32 -0.555572 0.831469 0 103.692 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="21" plane="0.923879 0.382685 0 -0.332571" album="" material="bm_edge_white" texgens="0 0 -1 32 -0.555572 0.831469 0 103.692 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="22" plane="0.471397 -0.881921 0 -0.26917" album="" material="bm_tile08_C" texgens="0 0 1 256 0.92388 0.382683 0 181.842 0 0.125 0.143507" texRot="0" texScale="0.125 0.143507" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="400" owner="0" type="0" pos="-3 33.1022 23.9623" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 -3 0 1 0 33.1022 -1 0 5.96046e-008 23.9623 0 0 0 1" group="-1" locked="0" nextFaceID="24" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.37706 0.131385 1" />
                            <Vertex pos="0.279515 0.330555 1" />
                            <Vertex pos="-0.185719 -0.330555 1" />
                            <Vertex pos="0.37706 -0.159836 1" />
                            <Vertex pos="-0.37706 0.131385 -1" />
                            <Vertex pos="0.279515 0.330555 -1" />
                            <Vertex pos="-0.185719 -0.330555 -1" />
                            <Vertex pos="0.37706 -0.159836 -1" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_edge_white" texgens="0.92388 0.382683 0 9.53854 0.290285 -0.95694 0 7.52581 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 -0 -1 -1" album="" material="bm_edge_white" texgens="0.932045 0.359855 -0.0423762 8.377 0.251737 -0.829867 0.497945 22.4607 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="19" plane="-0.290285 0.95694 0 -0.235182" album="" material="bm_grid_blank1" texgens="0 0 -1 128 0.92388 0.382683 0 156.486 0 0.25 0.33485" texRot="0" texScale="0.25 0.33485" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="20" plane="-0.92388 -0.382682 0 -0.29808" album="" material="bm_edge_white" texgens="0 0 -1 32 -0.382683 0.92388 0 103.498 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="21" plane="0.980785 0.195091 0 -0.338632" album="" material="bm_edge_white" texgens="0 0 -1 32 -0.382683 0.92388 0 103.498 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="22" plane="0.290288 -0.956939 0 -0.262409" album="" material="bm_tile08_C" texgens="0 0 1 256 0.92388 0.382683 0 322.469 0 0.125 0.143507" texRot="0" texScale="0.125 0.143507" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="401" owner="0" type="0" pos="-3 33.2212 23.3414" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 -3 0 1 0 33.2212 -1 0 5.96046e-008 23.3414 0 0 0 1" group="-1" locked="0" nextFaceID="24" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.341409 0.21157 1" />
                            <Vertex pos="0.341409 0.27882 1" />
                            <Vertex pos="-0.243865 -0.27882 1" />
                            <Vertex pos="0.341409 -0.221179 1" />
                            <Vertex pos="-0.341409 0.21157 -1" />
                            <Vertex pos="0.341409 0.27882 -1" />
                            <Vertex pos="-0.243865 -0.27882 -1" />
                            <Vertex pos="0.341409 -0.221179 -1" />
                        </Vertices>
                        <Face id="17" plane="0 -0 1 -1" album="" material="bm_edge_white" texgens="0.980785 0.19509 0 9.39437 0.0980146 -0.995185 0 7.80848 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 -0 -1 -1" album="" material="bm_edge_white" texgens="0.984341 0.171107 -0.0423774 8.2395 0.0849991 -0.863033 0.497945 22.7058 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="19" plane="-0.0980147 0.995185 0 -0.244014" album="" material="bm_grid_blank1" texgens="0 0 -1 128 0.92388 0.382683 0 215.66 0 0.25 0.33485" texRot="0" texScale="0.25 0.33485" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="20" plane="-0.980785 -0.195089 0 -0.293574" album="" material="bm_edge_white" texgens="0 0 -1 32 -0.19509 0.980785 0 103.229 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="21" plane="1 -0 0 -0.341409" album="" material="bm_edge_white" texgens="0 0 -1 32 -0.19509 0.980785 0 103.229 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="22" plane="0.0980114 -0.995185 0 -0.253576" album="" material="bm_tile08_C" texgens="0 0 1 256 0.92388 0.382683 0 460.539 0 0.125 0.143507" texRot="0" texScale="0.125 0.143507" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="402" owner="0" type="0" pos="-3 33.2212 22.6586" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 -3 0 1 0 33.2212 -1 0 5.96046e-008 22.6586 0 0 0 1" group="-1" locked="0" nextFaceID="24" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.341409 0.27882 1" />
                            <Vertex pos="0.341409 0.21157 1" />
                            <Vertex pos="-0.341409 -0.22118 1" />
                            <Vertex pos="0.243864 -0.27882 1" />
                            <Vertex pos="-0.341409 0.27882 -1" />
                            <Vertex pos="0.341409 0.21157 -1" />
                            <Vertex pos="-0.341409 -0.22118 -1" />
                            <Vertex pos="0.243864 -0.27882 -1" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 10.9251 -0.0980148 -0.995185 0 7.80846 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="18" plane="-0 0 -1 -1" album="" material="bm_edge_white" texgens="0.998808 -0.0242153 -0.042375 9.77211 -0.0849992 -0.863033 0.497945 22.7058 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="19" plane="0.0980147 0.995185 0 -0.244014" album="" material="bm_grid_blank1" texgens="0 0 -1 128 0.923879 -0.382684 0 40.3398 0 0.25 0.334849" texRot="0" texScale="0.25 0.334849" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="20" plane="-1 0 0 -0.341409" album="" material="bm_edge_white" texgens="0 0 -1 32 0 1 0 103.078 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="21" plane="0.980785 -0.195091 0 -0.293573" album="" material="bm_edge_white" texgens="0 0 -1 32 0 1 0 103.078 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="22" plane="-0.0980098 -0.995185 0 -0.253577" album="" material="bm_tile08_C" texgens="0 0 1 256 0.923879 -0.382686 0 51.4595 0 0.125 0.143507" texRot="0" texScale="0.125 0.143507" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="403" owner="0" type="0" pos="-3 33.1022 22.0377" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 -3 0 1 0 33.1022 -1 0 5.96046e-008 22.0377 0 0 0 1" group="-1" locked="0" nextFaceID="24" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.279517 0.330554 1" />
                            <Vertex pos="0.377062 0.131385 1" />
                            <Vertex pos="-0.377062 -0.159836 1" />
                            <Vertex pos="0.18572 -0.330554 1" />
                            <Vertex pos="-0.279517 0.330554 -1" />
                            <Vertex pos="0.377062 0.131385 -1" />
                            <Vertex pos="-0.377062 -0.159836 -1" />
                            <Vertex pos="0.18572 -0.330554 -1" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="0.980785 -0.195092 0 10.8363 -0.290283 -0.956941 0 7.52584 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="18" plane="-0 0 -1 -1" album="" material="bm_edge_white" texgens="0.974892 -0.218608 -0.0423752 9.67634 -0.251736 -0.829867 0.497945 22.4607 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="19" plane="0.290282 0.956941 0 -0.235182" album="" material="bm_grid_blank1" texgens="0 0 -1 128 0.923879 -0.382684 0 99.5137 0 0.25 0.334849" texRot="0" texScale="0.25 0.334849" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="20" plane="-0.980785 0.195091 0 -0.338634" album="" material="bm_edge_white" texgens="0 0 -1 32 0.195092 0.980785 0 103.371 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="21" plane="0.923879 -0.382684 0 -0.298081" album="" material="bm_edge_white" texgens="0 0 -1 32 0.195092 0.980785 0 103.371 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="22" plane="-0.290285 -0.95694 0 -0.262409" album="" material="bm_tile08_C" texgens="0 0 1 256 0.923879 -0.382686 0 189.532 0 0.125 0.143507" texRot="0" texScale="0.125 0.143507" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="404" owner="0" type="0" pos="-3 32.864 21.4537" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 -3 0 1 0 32.864 -1 0 5.96046e-008 21.4537 0 0 0 1" group="-1" locked="0" nextFaceID="24" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.206879 0.369584 1" />
                            <Vertex pos="0.398221 0.046144 1" />
                            <Vertex pos="-0.398221 -0.0923543 1" />
                            <Vertex pos="0.120439 -0.369584 1" />
                            <Vertex pos="-0.206879 0.369584 -1" />
                            <Vertex pos="0.398221 0.046144 -1" />
                            <Vertex pos="-0.398221 -0.0923543 -1" />
                            <Vertex pos="0.120439 -0.369584 -1" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="0.923879 -0.382685 0 10.6421 -0.471405 -0.881917 0 7.3094 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="18" plane="-0 0 -1 -1" album="" material="bm_edge_white" texgens="0.91351 -0.404603 -0.0423797 9.47651 -0.408807 -0.764806 0.497945 22.273 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="19" plane="0.471405 0.881917 0 -0.228419" album="" material="bm_grid_blank1" texgens="0 0 -1 128 0.923879 -0.382684 0 159.781 0 0.25 0.334849" texRot="0" texScale="0.25 0.334849" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="20" plane="-0.923879 0.382685 0 -0.332565" album="" material="bm_edge_white" texgens="0 0 -1 32 0.382685 0.923879 0 103.607 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="21" plane="0.831468 -0.555572 0 -0.305472" album="" material="bm_edge_white" texgens="0 0 -1 32 0.382685 0.923879 0 103.607 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="22" plane="-0.471397 -0.881921 0 -0.269169" album="" material="bm_tile08_C" texgens="0 0 1 256 0.923879 -0.382686 0 330.157 0 0.125 0.143507" texRot="0" texScale="0.125 0.143507" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="405" owner="0" type="0" pos="-3 32.5157 20.9292" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 -3 0 1 0 32.5157 -1 0 5.96046e-008 20.9292 0 0 0 1" group="-1" locked="0" nextFaceID="24" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.126299 0.394412 1" />
                            <Vertex pos="0.404081 -0.0408576 1" />
                            <Vertex pos="-0.404081 -0.0213161 1" />
                            <Vertex pos="0.050525 -0.394412 1" />
                            <Vertex pos="-0.126299 0.394412 -1" />
                            <Vertex pos="0.404081 -0.0408576 -1" />
                            <Vertex pos="-0.404081 -0.0213161 -1" />
                            <Vertex pos="0.050525 -0.394412 -1" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="0.831469 -0.555572 0 10.3724 -0.634392 -0.773012 0 7.19241 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="18" plane="-0 0 -1 -1" album="" material="bm_edge_white" texgens="0.817025 -0.575043 -0.0423751 9.20379 -0.55015 -0.670362 0.497945 22.1716 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="19" plane="0.634392 0.773012 0 -0.224762" album="" material="bm_grid_blank1" texgens="0 0 -1 128 0.923879 -0.382684 0 218.829 0 0.25 0.334849" texRot="0" texScale="0.25 0.334849" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="20" plane="-0.831468 0.555572 0 -0.324138" album="" material="bm_edge_white" texgens="0 0 -1 32 0.555572 0.831469 0 103.751 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="21" plane="0.707105 -0.707108 0 -0.314618" album="" material="bm_edge_white" texgens="0 0 -1 32 0.555572 0.831469 0 103.751 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="22" plane="-0.634404 -0.773002 0 -0.272828" album="" material="bm_tile08_C" texgens="0 0 1 256 0.923879 -0.382686 0 467.934 0 0.125 0.143507" texRot="0" texScale="0.125 0.143507" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="406" owner="0" type="0" pos="-3 32.0708 20.4843" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 -3 0 1 0 32.0708 -1 0 5.96046e-008 20.4843 0 0 0 1" group="-1" locked="0" nextFaceID="24" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.0408573 0.404084 1" />
                            <Vertex pos="0.394413 -0.126296 1" />
                            <Vertex pos="-0.394413 0.0505302 1" />
                            <Vertex pos="-0.0213287 -0.404084 1" />
                            <Vertex pos="-0.0408573 0.404084 -1" />
                            <Vertex pos="0.394413 -0.126296 -1" />
                            <Vertex pos="-0.394413 0.0505302 -1" />
                            <Vertex pos="-0.0213287 -0.404084 -1" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="0.707105 -0.707108 0 10.0679 -0.773012 -0.634392 0 7.19246 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="18" plane="-0 0 -1 -1" album="" material="bm_edge_white" texgens="0.68914 -0.723388 -0.0423765 8.89887 -0.670362 -0.55015 0.497945 22.1716 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="19" plane="0.773011 0.634392 0 -0.224765" album="" material="bm_grid_blank1" texgens="0 0 -1 128 0.38268 -0.923881 0 37.1714 0 0.25 0.334847" texRot="0" texScale="0.25 0.334847" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="20" plane="-0.707105 0.707109 0 -0.314622" album="" material="bm_edge_white" texgens="0 0 -1 32 0.707108 0.707105 0 103.781 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="21" plane="0.555568 -0.831471 0 -0.324135" album="" material="bm_edge_white" texgens="0 0 -1 32 0.707108 0.707105 0 103.781 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="22" plane="-0.773017 -0.634385 0 -0.272832" album="" material="bm_tile08_C" texgens="0 0 1 256 0.382681 -0.923881 0 44.0664 0 0.125 0.143506" texRot="0" texScale="0.125 0.143506" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="407" owner="0" type="0" pos="-3 31.5463 20.136" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 -3 0 1 0 31.5463 -1 0 5.96046e-008 20.136 0 0 0 1" group="-1" locked="0" nextFaceID="24" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.0461555 0.398225 1" />
                            <Vertex pos="0.369586 -0.206885 1" />
                            <Vertex pos="-0.369586 0.120437 1" />
                            <Vertex pos="-0.0923548 -0.398225 1" />
                            <Vertex pos="0.0461555 0.398225 -1" />
                            <Vertex pos="0.369586 -0.206885 -1" />
                            <Vertex pos="-0.369586 0.120437 -1" />
                            <Vertex pos="-0.0923548 -0.398225 -1" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="0.555568 -0.831471 0 9.77504 -0.881926 -0.471388 0 7.30959 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="18" plane="-0 0 -1 -1" album="" material="bm_edge_white" texgens="0.53477 -0.843934 -0.04238 8.60842 -0.764814 -0.408791 0.497945 22.2732 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="19" plane="0.881926 0.471388 0 -0.228424" album="" material="bm_grid_blank1" texgens="0 0 -1 128 0.38268 -0.923881 0 96.2188 0 0.25 0.334847" texRot="0" texScale="0.25 0.334847" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="20" plane="-0.555568 0.831471 0 -0.30547" album="" material="bm_edge_white" texgens="0 0 -1 32 0.831471 0.555568 0 103.692 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="21" plane="0.38268 -0.923881 0 -0.33257" album="" material="bm_edge_white" texgens="0 0 -1 32 0.831471 0.555568 0 103.692 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="22" plane="-0.881921 -0.471397 0 -0.269172" album="" material="bm_tile08_C" texgens="0 0 1 256 0.382681 -0.923881 0 181.842 0 0.125 0.143506" texRot="0" texScale="0.125 0.143506" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="408" owner="0" type="0" pos="-3 30.9623 19.8978" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 -3 0 1 0 30.9623 -1 0 5.96046e-008 19.8978 0 0 0 1" group="-1" locked="0" nextFaceID="24" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.131385 0.377061 1" />
                            <Vertex pos="0.330555 -0.279518 1" />
                            <Vertex pos="-0.330555 0.185721 1" />
                            <Vertex pos="-0.159836 -0.377061 1" />
                            <Vertex pos="0.131385 0.377061 -1" />
                            <Vertex pos="0.330555 -0.279518 -1" />
                            <Vertex pos="-0.330555 0.185721 -1" />
                            <Vertex pos="-0.159836 -0.377061 -1" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="0.38268 -0.923881 0 9.53859 -0.956941 -0.290283 0 7.52581 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="18" plane="-0 0 -1 -1" album="" material="bm_edge_white" texgens="0.359853 -0.932046 -0.0423758 8.37706 -0.829867 -0.251736 0.497946 22.4607 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="19" plane="0.956941 0.290283 0 -0.235182" album="" material="bm_grid_blank1" texgens="0 0 -1 128 0.38268 -0.923881 0 156.487 0 0.25 0.334847" texRot="0" texScale="0.25 0.334847" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="20" plane="-0.38268 0.923881 0 -0.298081" album="" material="bm_edge_white" texgens="0 0 -1 32 0.923881 0.38268 0 103.498 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="21" plane="0.195087 -0.980786 0 -0.338634" album="" material="bm_edge_white" texgens="0 0 -1 32 0.923881 0.38268 0 103.498 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="22" plane="-0.95694 -0.290286 0 -0.262409" album="" material="bm_tile08_C" texgens="0 0 1 256 0.382681 -0.923881 0 322.469 0 0.125 0.143506" texRot="0" texScale="0.125 0.143506" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="409" owner="0" type="0" pos="-3 30.3414 19.7788" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 -3 0 1 0 30.3414 -1 0 5.96046e-008 19.7788 0 0 0 1" group="-1" locked="0" nextFaceID="24" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.21157 0.341401 1" />
                            <Vertex pos="0.27882 -0.341401 1" />
                            <Vertex pos="-0.27882 0.243858 1" />
                            <Vertex pos="-0.22118 -0.341401 1" />
                            <Vertex pos="0.21157 0.341401 -1" />
                            <Vertex pos="0.27882 -0.341401 -1" />
                            <Vertex pos="-0.27882 0.243858 -1" />
                            <Vertex pos="-0.22118 -0.341401 -1" />
                        </Vertices>
                        <Face id="17" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="0.195086 -0.980786 0 9.39413 -0.995185 -0.0980171 0 7.80847 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="18" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="0.171105 -0.984341 -0.0423747 8.23934 -0.863032 -0.0850013 0.497945 22.7058 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="19" plane="0.995185 0.098017 0 -0.244014" album="" material="bm_grid_blank1" texgens="0 0 -1 128 0.38268 -0.923881 0 215.66 0 0.25 0.334847" texRot="0" texScale="0.25 0.334847" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="20" plane="-0.195087 0.980786 0 -0.293567" album="" material="bm_edge_white" texgens="0 0 -1 32 0.980786 0.195086 0 103.229 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="21" plane="0 -1 0 -0.341401" album="" material="bm_edge_white" texgens="0 0 -1 32 0.980786 0.195086 0 103.229 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="22" plane="-0.995185 -0.0980121 0 -0.253577" album="" material="bm_tile08_C" texgens="0 0 1 256 0.382681 -0.923881 0 460.541 0 0.125 0.143506" texRot="0" texScale="0.125 0.143506" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="410" owner="0" type="0" pos="16 16 -2.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 16 0 0 1 -2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -23.75" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -23.75" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -23.75" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -23.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile09_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -23.75" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="411" owner="0" type="0" pos="16 24 -2.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 24 0 0 1 -2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 10.25" />
                            <Vertex pos="2 2 -23.75" />
                            <Vertex pos="2 -2 10.25" />
                            <Vertex pos="2 -2 -23.75" />
                            <Vertex pos="-2 2 10.25" />
                            <Vertex pos="-2 2 -23.75" />
                            <Vertex pos="-2 -2 10.25" />
                            <Vertex pos="-2 -2 -23.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 512 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -512 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10.25" album="" material="bm_tile11_C" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -23.75" album="" material="bm_grid_blank1" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="412" owner="0" type="0" pos="20 33 -8" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 33 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -7 4" />
                            <Vertex pos="2 -7 -18" />
                            <Vertex pos="2 -11 4" />
                            <Vertex pos="2 -11 -18" />
                            <Vertex pos="-2 -7 4" />
                            <Vertex pos="-2 -7 -18" />
                            <Vertex pos="-2 -11 4" />
                            <Vertex pos="-2 -11 -18" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank1" texgens="0 1 0 2688 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank1" texgens="0 -1 0 -2688 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 7" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -11" album="" material="bm_grid_blank1" texgens="1 0 0 512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_friction_ice" texgens="1 0 0 0 0 -1 0 3840 180 0.125 0.125" texRot="180" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -18" album="" material="bm_grid_blank1" texgens="-1 0 0 -512 0 -1 0 -2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="416" owner="0" type="0" pos="11 22 -12" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 22 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 6" />
                            <Vertex pos="1 4 -14" />
                            <Vertex pos="1 0 6" />
                            <Vertex pos="1 0 -14" />
                            <Vertex pos="-1 4 6" />
                            <Vertex pos="-1 4 -14" />
                            <Vertex pos="-1 0 6" />
                            <Vertex pos="-1 0 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank1" texgens="0 1 0 768 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank1" texgens="0 -1 0 -768 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_grid_blank1" texgens="1 0 0 128 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_tile11_C" texgens="1 0 0 256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank1" texgens="-1 0 0 -128 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
