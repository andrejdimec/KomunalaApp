 SELECT  dbo.ren_Strehe.id,dbo.ren_Strehe.objectid,dbo.ren_Strehe.hsmid_gl,dbo.ren_Strehe.SID, dbo.ren_Strehe.om_ime,dbo.tbl_ren_stavbe.st_stanovanj, dbo.tbl_ren_stavbe.st_poslovnih_prostorov
                            , dbo.tbl_ren_deli_stavb.dst_sid, dbo.ren_Strehe.HSMID_GL, dbo.tbl_ren_deli_stavb.stevstan 
                            , dbo.tbl_ren_deli_stavb.dejanska_raba AS dej, dbo.ren_Strehe.Povrsina, dbo.tbl_ren_deli_stavb.neto_tloris_pov_dst
                            , dbo.tbl_ren_deli_stavb.hs_mid
                    FROM     dbo.ren_Strehe INNER JOIN
                                  dbo.tbl_ren_stavbe ON dbo.ren_Strehe.SID = dbo.tbl_ren_stavbe.sta_sid INNER JOIN
                                  dbo.tbl_ren_deli_stavb ON dbo.ren_Strehe.SID = dbo.tbl_ren_deli_stavb.sta_sid
                    WHERE        (dbo.ren_Strehe.Glavna_streha = N'1')  and (dbo.ren_Strehe.id< N'1000')
                    ORDER BY dbo.ren_Strehe.SID