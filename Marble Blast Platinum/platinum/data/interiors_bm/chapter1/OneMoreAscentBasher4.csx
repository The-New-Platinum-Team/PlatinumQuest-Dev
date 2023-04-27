<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2022/07/22 18:47:43">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="5">
        <SceneShape id="0" type="1" entityID="2" dl="0" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="3" dl="0" group="-1" locked="0" />
        <SceneShape id="2" type="1" entityID="4" dl="0" group="-1" locked="0" />
        <SceneShape id="3" type="1" entityID="5" dl="0" group="-1" locked="0" />
        <SceneShape id="4" type="1" entityID="6" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="7">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32.0" light_geometry_scale="8.0" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="2" classname="path_node" gametype="Torque" isPointEntity="1" origin="-7 -108 40" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="-7 -122 40" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="4" classname="path_node" gametype="Torque" isPointEntity="1" origin="-7 -122 40" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="5" classname="path_node" gametype="Torque" isPointEntity="1" origin="-7 -108 40" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="6" classname="path_node" gametype="Torque" isPointEntity="1" origin="-7 -108 40" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="3">
                    <Brush id="0" owner="0" type="0" pos="-3 -117 37.5" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -117 0 0 1 37.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 -1" />
                            <Vertex pos="6 2 -2" />
                            <Vertex pos="6 -2 -1" />
                            <Vertex pos="6 -2 -2" />
                            <Vertex pos="-6 2 2" />
                            <Vertex pos="-6 2 1" />
                            <Vertex pos="-6 -2 2" />
                            <Vertex pos="-6 -2 1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -2304 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.485071" album="Blasted" material="bm_tile07_B" texgens="1 0 0 512 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970142 -0.485071" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="-11 -113 39.5" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 -113 0 0 1 39.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 -1" />
                            <Vertex pos="6 2 -2" />
                            <Vertex pos="6 -2 -1" />
                            <Vertex pos="6 -2 -2" />
                            <Vertex pos="-6 2 2" />
                            <Vertex pos="-6 2 1" />
                            <Vertex pos="-6 -2 2" />
                            <Vertex pos="-6 -2 1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -2304 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 1792 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.485071" album="Blasted" material="bm_tile07_B" texgens="1 0 0 512 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970142 -0.485071" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="1" type="999" pos="-7 -108 40" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -108 0 0 1 40 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.75" />
                            <Vertex pos="1 1 -1.25" />
                            <Vertex pos="1 -1 0.75" />
                            <Vertex pos="1 -1 -1.25" />
                            <Vertex pos="-1 1 1.25" />
                            <Vertex pos="-1 1 -0.75" />
                            <Vertex pos="-1 -1 1.25" />
                            <Vertex pos="-1 -1 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_basher" texgens="0 1 0 256 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_basher" texgens="0 -1 0 256 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_basher_side" texgens="-1 0 0 256 -0.25 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_basher_side" texgens="1 0 0 256 -0.25 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.970143" album="Blasted" material="bm_basher_top" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.970143" album="Blasted" material="bm_basher_top" texgens="-1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
