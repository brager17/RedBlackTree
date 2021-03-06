using System;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using RedBlackTreeStructure;
using Xunit;
using Xunit.Abstractions;

namespace ConsoleApp1.Tests
{
    namespace CustomDictionary.Tests
    {
        public class DeleteTests
        {
            [Fact]
            public void TestCase5__Case1()
            {
                var nd = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Black,
                    Value = 2,
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 1,
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Value = 3,
                        Color = RedBlackTree.Color.Black,
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Red,
                            Value = 4,
                        }
                    }
                };

                var tree = new RedBlackTree(nd);
                tree.Remove(3);
                var expected = new RedBlackTree.Node()
                {
                    Value = 2,
                    Color = RedBlackTree.Color.Black,
                    Left = new RedBlackTree.Node()
                    {
                        Value = 1,
                        Color = RedBlackTree.Color.Black,
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Value = 4,
                        Color = RedBlackTree.Color.Black
                    }
                };

                Assert.Equal(expected, tree._root, RedBlackTree.NodeEqualityComparer.Comparer);
            }

            [Fact]
            public void Delete6()
            {
                var nd = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Black,
                    Value = 4,
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 2,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 1,
                            Color = RedBlackTree.Color.Black
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Black,
                            Value = 3
                        }
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 6,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 5,
                            Color = RedBlackTree.Color.Black
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Red,
                            Value = 8,
                            Left = new RedBlackTree.Node()
                            {
                                Value = 7,
                                Color = RedBlackTree.Color.Black
                            },
                            Right = new RedBlackTree.Node()
                            {
                                Value = 9,
                                Color = RedBlackTree.Color.Black,
                                Right = new RedBlackTree.Node()
                                {
                                    Color = RedBlackTree.Color.Red,
                                    Value = 10
                                }
                            }
                        }
                    }
                };

                var tree = new RedBlackTree(nd);
                tree.Remove(6);

                var expected = new RedBlackTree.Node()
                {
                    Value = 4,
                    Color = RedBlackTree.Color.Black,
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 2,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 1,
                            Color = RedBlackTree.Color.Black
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Black,
                            Value = 3
                        }
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Value = 8,
                        Color = RedBlackTree.Color.Black,
                        Right = new RedBlackTree.Node()
                        {
                            Value = 9,
                            Color = RedBlackTree.Color.Black,
                            Right = new RedBlackTree.Node()
                            {
                                Color = RedBlackTree.Color.Red,
                                Value = 10
                            }
                        },
                        Left = new RedBlackTree.Node()
                        {
                            Value = 5,
                            Color = RedBlackTree.Color.Black,
                            Right = new RedBlackTree.Node()
                            {
                                Value = 7,
                                Color = RedBlackTree.Color.Red
                            }
                        }
                    }
                };

                Assert.Equal(expected, tree._root, RedBlackTree.NodeEqualityComparer.Comparer);
            }

            [Fact]
            public void Delete4()
            {
                var nd = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Black,
                    Value = 4,
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 2,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 1,
                            Color = RedBlackTree.Color.Black
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Black,
                            Value = 3
                        }
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 6,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 5,
                            Color = RedBlackTree.Color.Black
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Red,
                            Value = 8,
                            Left = new RedBlackTree.Node()
                            {
                                Value = 7,
                                Color = RedBlackTree.Color.Black
                            },
                            Right = new RedBlackTree.Node()
                            {
                                Value = 9,
                                Color = RedBlackTree.Color.Black,
                                Right = new RedBlackTree.Node()
                                {
                                    Color = RedBlackTree.Color.Red,
                                    Value = 10
                                }
                            }
                        }
                    }
                };

                var tree = new RedBlackTree(nd);
                tree.Remove(4);

                var expected = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Black,
                    Value = 6,
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 3,
                        Left = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Black,
                            Value = 2,
                            Left = new RedBlackTree.Node()
                            {
                                Color = RedBlackTree.Color.Red,
                                Value = 1
                            }
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Value = 5,
                            Color = RedBlackTree.Color.Black
                        }
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Value = 8,
                        Color = RedBlackTree.Color.Black,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 7, Color = RedBlackTree.Color.Black
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Value = 9,
                            Color = RedBlackTree.Color.Black,
                            Right = new RedBlackTree.Node()
                            {
                                Value = 10,
                                Color = RedBlackTree.Color.Red
                            }
                        }
                    }
                };

                Assert.Equal(expected, tree._root, RedBlackTree.NodeEqualityComparer.Comparer);
            }

            [Fact]
            public void Delete1()
            {
                var nd = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Black,
                    Value = 4,
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 2,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 1,
                            Color = RedBlackTree.Color.Black
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Black,
                            Value = 3
                        }
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 6,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 5,
                            Color = RedBlackTree.Color.Black
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Red,
                            Value = 8,
                            Left = new RedBlackTree.Node()
                            {
                                Value = 7,
                                Color = RedBlackTree.Color.Black
                            },
                            Right = new RedBlackTree.Node()
                            {
                                Value = 9,
                                Color = RedBlackTree.Color.Black,
                                Right = new RedBlackTree.Node()
                                {
                                    Color = RedBlackTree.Color.Red,
                                    Value = 10
                                }
                            }
                        }
                    }
                };

                var tree = new RedBlackTree(nd);
                tree.Remove(1);

                var expected = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Black,
                    Value = 6,
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 4,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 2,
                            Color = RedBlackTree.Color.Black,
                            Right = new RedBlackTree.Node()
                            {
                                Color = RedBlackTree.Color.Red,
                                Value = 3
                            }
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Black,
                            Value = 5
                        }
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 8,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 7,
                            Color = RedBlackTree.Color.Black
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Black,
                            Value = 9,
                            Right = new RedBlackTree.Node()
                            {
                                Value = 10,
                                Color = RedBlackTree.Color.Red,
                            }
                        }
                    }
                };

                Assert.Equal(expected, tree._root, RedBlackTree.NodeEqualityComparer.Comparer);
            }

            [Fact]
            public void Delete3()
            {
                var nd = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Black,
                    Value = 4,
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 2,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 1,
                            Color = RedBlackTree.Color.Black
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Black,
                            Value = 3
                        }
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 6,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 5,
                            Color = RedBlackTree.Color.Black
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Red,
                            Value = 8,
                            Left = new RedBlackTree.Node()
                            {
                                Value = 7,
                                Color = RedBlackTree.Color.Black
                            },
                            Right = new RedBlackTree.Node()
                            {
                                Value = 9,
                                Color = RedBlackTree.Color.Black,
                                Right = new RedBlackTree.Node()
                                {
                                    Color = RedBlackTree.Color.Red,
                                    Value = 10
                                }
                            }
                        }
                    }
                };

                var tree = new RedBlackTree(nd);
                tree.Remove(3);

                var expected = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Black,
                    Value = 6,
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 4,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 2,
                            Color = RedBlackTree.Color.Black,
                            Left = new RedBlackTree.Node()
                            {
                                Color = RedBlackTree.Color.Red,
                                Value = 1
                            }
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Black,
                            Value = 5
                        }
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 8,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 7,
                            Color = RedBlackTree.Color.Black
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Black,
                            Value = 9,
                            Right = new RedBlackTree.Node()
                            {
                                Value = 10,
                                Color = RedBlackTree.Color.Red,
                            }
                        }
                    }
                };

                Assert.Equal(expected, tree._root, RedBlackTree.NodeEqualityComparer.Comparer);
            }

            [Fact]
            public void Delete2()
            {
                var nd = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Black,
                    Value = 4,
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 2,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 1,
                            Color = RedBlackTree.Color.Black
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Black,
                            Value = 3
                        }
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 6,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 5,
                            Color = RedBlackTree.Color.Black
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Red,
                            Value = 8,
                            Left = new RedBlackTree.Node()
                            {
                                Value = 7,
                                Color = RedBlackTree.Color.Black
                            },
                            Right = new RedBlackTree.Node()
                            {
                                Value = 9,
                                Color = RedBlackTree.Color.Black,
                                Right = new RedBlackTree.Node()
                                {
                                    Color = RedBlackTree.Color.Red,
                                    Value = 10
                                }
                            }
                        }
                    }
                };

                var tree = new RedBlackTree(nd);
                tree.Remove(2);

                var expected = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Black,
                    Value = 6,
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 4,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 1,
                            Color = RedBlackTree.Color.Black,
                            Right = new RedBlackTree.Node()
                            {
                                Color = RedBlackTree.Color.Red,
                                Value = 3
                            }
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Black,
                            Value = 5
                        }
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 8,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 7,
                            Color = RedBlackTree.Color.Black
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Black,
                            Value = 9,
                            Right = new RedBlackTree.Node()
                            {
                                Value = 10,
                                Color = RedBlackTree.Color.Red,
                            }
                        }
                    }
                };

                Assert.Equal(expected, tree._root, RedBlackTree.NodeEqualityComparer.Comparer);
            }

            [Fact]
            public void DeleteNodeWithOneChild()
            {
                var root = new RedBlackTree.Node()
                {
                    Left = new RedBlackTree.Node()
                    {
                        Value = 5,
                        Color = RedBlackTree.Color.Black
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Red,
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Black,
                            Value = 20,
                            Right = new RedBlackTree.Node()
                            {
                                Value = 21,
                                Color = RedBlackTree.Color.Red
                            },
                            Left = new RedBlackTree.Node()
                            {
                                Value = 19,
                                Color = RedBlackTree.Color.Red
                            }
                        },
                        Left = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Black,
                            Value = 14
                        },
                        Value = 15,
                    },
                    Value = 10,
                    Color = RedBlackTree.Color.Black
                };
                var tree = new RedBlackTree(root);
                tree.Remove(15);

                var expected = new RedBlackTree.Node()
                {
                    Left = new RedBlackTree.Node()
                    {
                        Value = 5,
                        Color = RedBlackTree.Color.Black
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Red,
                        Right = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Black,
                            Value = 21,
                        },
                        Left = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Black,
                            Value = 14,
                            Right = new RedBlackTree.Node()
                            {
                                Color = RedBlackTree.Color.Red,
                                Value = 19
                            }
                        },
                        Value = 20,
                    },
                    Value = 10,
                    Color = RedBlackTree.Color.Black
                };

                Assert.Equal(expected, tree._root, RedBlackTree.NodeEqualityComparer.Comparer);
            }

            [Fact]
            public void Case1Test__Case5Test()
            {
                var nd = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Black,
                    Value = 10,
                    Left = new RedBlackTree.Node()
                    {
                        Value = 5,
                        Color = RedBlackTree.Color.Black
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Value = 15,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 14,
                            Color = RedBlackTree.Color.Red
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Value = 16,
                            Color = RedBlackTree.Color.Red
                        },
                        Color = RedBlackTree.Color.Black
                    }
                };

                var tree = new RedBlackTree(nd);
                tree.Remove(5);
                var expected = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Black,
                    Value = 15,
                    Right = new RedBlackTree.Node()
                    {
                        Value = 16,
                        Color = RedBlackTree.Color.Black
                    },
                    Left = new RedBlackTree.Node()
                    {
                        Value = 10,
                        Color = RedBlackTree.Color.Black,
                        Right = new RedBlackTree.Node()
                        {
                            Value = 14,
                            Color = RedBlackTree.Color.Red
                        }
                    },
                };
                Assert.Equal(expected, tree._root, RedBlackTree.NodeEqualityComparer.Comparer);
            }

            [Fact]
            public void DeleteRedNodeWith2Children__NotWorking()
            {
                var root = new RedBlackTree.Node
                {
                    Value = 2,
                    Color = RedBlackTree.Color.Black,
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 1
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Red,
                        Value = 4,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 3, Color = RedBlackTree.Color.Black
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Value = 5,
                            Color = RedBlackTree.Color.Black,
                            Right = new RedBlackTree.Node()
                            {
                                Color = RedBlackTree.Color.Red,
                                Value = 6
                            }
                        }
                    }
                };

                var tree = new RedBlackTree(root);
                tree.Remove(4);

                var expected = new RedBlackTree.Node
                {
                    Value = 2,
                    Color = RedBlackTree.Color.Black,
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = 1
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Red,
                        Value = 5,
                        Left = new RedBlackTree.Node()
                        {
                            Value = 3, Color = RedBlackTree.Color.Black
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Value = 6,
                            Color = RedBlackTree.Color.Black,
                        }
                    }
                };

                Assert.Equal(expected, tree._root, new RedBlackTree.NodeEqualityComparer());
            }

            [Fact]
            public void RemoveNodeWithoutChild()
            {
                var root = new RedBlackTree.Node
                {
                    Value = 2,
                    Color = RedBlackTree.Color.Black,
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Red,
                        Value = 1
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Red,
                        Value = 3
                    }
                };

                var tree = new RedBlackTree(root);
                tree.Remove(3);

                var expected = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Black,
                    Value = 2,
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Red,
                        Value = 1
                    }
                };

                Assert.Equal(expected, tree._root, new RedBlackTree.NodeEqualityComparer());
            }
        }

        public class InsertTests
        {
            [Fact]
            public void InsertInRoot()
            {
                var tree = new RedBlackTree();
                tree.Insert(1);
                Assert.True(tree.Contains(1));
            }

            [Fact]
            public void InsertInRoot__InRightRootChild()
            {
                var tree = new RedBlackTree();
                tree.Insert(1);
                tree.Insert(2);
                Assert.True(tree.Contains(1));
                Assert.True(tree.Contains(2));

                Assert.Equal(1, tree._root.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Color);
                Assert.Equal(2, tree._root.Right.Value);
                Assert.Equal(RedBlackTree.Color.Red, tree._root.Right.Color);
            }


            [Fact]
            public void NeedBalancingRR()
            {
                var tree = new RedBlackTree();
                tree.Insert(1);
                tree.Insert(2);
                tree.Insert(3);
                Assert.True(tree.Contains(1));
                Assert.True(tree.Contains(2));
                Assert.True(tree.Contains(3));

                Assert.Equal(2, tree._root.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Color);
                Assert.Equal(3, tree._root.Right.Value);
                Assert.Equal(RedBlackTree.Color.Red, tree._root.Right.Color);
                Assert.Equal(1, tree._root.Left.Value);
                Assert.Equal(RedBlackTree.Color.Red, tree._root.Left.Color);
            }

            [Fact]
            public void NeedSimpleBalancing()
            {
                var tree = new RedBlackTree();
                tree.Insert(1);
                tree.Insert(2);
                tree.Insert(4);
                tree.Insert(3);
                Assert.True(tree.Contains(1));
                Assert.True(tree.Contains(2));
                Assert.True(tree.Contains(3));
                Assert.True(tree.Contains(4));


                Assert.Equal(2, tree._root.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Color);
                Assert.Equal(4, tree._root.Right.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Right.Color);
                Assert.Equal(1, tree._root.Left.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Left.Color);
                Assert.Equal(3, tree._root.Right.Left.Value);
                Assert.Equal(RedBlackTree.Color.Red, tree._root.Right.Left.Color);
            }

            [Fact]
            public void NeedBalancingLR()
            {
                var tree = new RedBlackTree();
                tree.Insert(1);
                tree.Insert(2);
                tree.Insert(5);
                tree.Insert(3);
                // https://neerc.ifmo.ru/wiki/index.php?title=%D0%9A%D1%80%D0%B0%D1%81%D0%BD%D0%BE-%D1%87%D0%B5%D1%80%D0%BD%D0%BE%D0%B5_%D0%B4%D0%B5%D1%80%D0%B5%D0%B2%D0%BE
                // SimpleBalancing - без поворотов
                // rrBalancing, значит нужно балансировать ноду которая правая для родителя и у родитель которой также правый для своего родителя(первая r - правость родителя, вторая - ноды)
                tree.Insert(4);
                Assert.True(tree.Contains(1));
                Assert.True(tree.Contains(2));
                Assert.True(tree.Contains(3));
                Assert.True(tree.Contains(4));
                Assert.True(tree.Contains(5));

                Assert.Equal(2, tree._root.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Color);
                Assert.Equal(1, tree._root.Left.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Left.Color);
                Assert.Equal(4, tree._root.Right.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Right.Color);
                Assert.Equal(3, tree._root.Right.Left.Value);
                Assert.Equal(RedBlackTree.Color.Red, tree._root.Right.Left.Color);
                Assert.Equal(5, tree._root.Right.Right.Value);
                Assert.Equal(RedBlackTree.Color.Red, tree._root.Right.Right.Color);
            }

            [Fact]
            public void NeedBalancingRL()
            {
                var tree = new RedBlackTree();
                tree.Insert(1);
                tree.Insert(0);
                tree.Insert(3);
                tree.Insert(5);
                tree.Insert(4);
                Assert.True(tree.Contains(0));
                Assert.True(tree.Contains(1));
                Assert.True(tree.Contains(3));
                Assert.True(tree.Contains(4));
                Assert.True(tree.Contains(5));

                Assert.Equal(1, tree._root.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Color);
                Assert.Equal(0, tree._root.Left.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Left.Color);
                Assert.Equal(4, tree._root.Right.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Right.Color);
                Assert.Equal(3, tree._root.Right.Left.Value);
                Assert.Equal(RedBlackTree.Color.Red, tree._root.Right.Left.Color);
                Assert.Equal(5, tree._root.Right.Right.Value);
                Assert.Equal(RedBlackTree.Color.Red, tree._root.Right.Right.Color);
            }

            [Fact]
            public void NeedBalancingLL()
            {
                var tree = new RedBlackTree();
                tree.Insert(5);
                tree.Insert(4);
                tree.Insert(3);
                tree.Insert(2);
                tree.Insert(1);
                Assert.True(tree.Contains(1));
                Assert.True(tree.Contains(2));
                Assert.True(tree.Contains(3));
                Assert.True(tree.Contains(4));
                Assert.True(tree.Contains(5));

                Assert.Equal(4, tree._root.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Color);
                Assert.Equal(2, tree._root.Left.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Left.Color);
                Assert.Equal(5, tree._root.Right.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Right.Color);
                Assert.Equal(1, tree._root.Left.Left.Value);
                Assert.Equal(RedBlackTree.Color.Red, tree._root.Left.Left.Color);
                Assert.Equal(3, tree._root.Left.Right.Value);
                Assert.Equal(RedBlackTree.Color.Red, tree._root.Left.Right.Color);
            }

            [Fact]
            public void NeedSimpleBalancing1()
            {
                var tree = new RedBlackTree();
                tree.Insert(100);
                tree.Insert(200);
                tree.Insert(50);
                tree.Insert(75);
                tree.Insert(25);
                tree.Insert(20);
                Assert.True(tree.Contains(100));
                Assert.True(tree.Contains(200));
                Assert.True(tree.Contains(50));
                Assert.True(tree.Contains(75));
                Assert.True(tree.Contains(25));
                Assert.True(tree.Contains(20));

                Assert.Equal(100, tree._root.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Color);
                Assert.Equal(50, tree._root.Left.Value);
                Assert.Equal(RedBlackTree.Color.Red, tree._root.Left.Color);
                Assert.Equal(200, tree._root.Right.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Right.Color);
                Assert.Equal(25, tree._root.Left.Left.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Left.Left.Color);
                Assert.Equal(75, tree._root.Left.Right.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Left.Right.Color);
                Assert.Equal(20, tree._root.Left.Left.Left.Value);
                Assert.Equal(RedBlackTree.Color.Red, tree._root.Left.Left.Left.Color);
            }

            [Fact]
            public void NeedSimpleBalancing__RightRotate()
            {
                var tree = new RedBlackTree();
                tree.Insert(100);
                tree.Insert(200);
                tree.Insert(50);
                tree.Insert(75);
                tree.Insert(25);
                tree.Insert(20);
                tree.Insert(35);
                tree.Insert(15);
                Assert.True(tree.Contains(100));
                Assert.True(tree.Contains(200));
                Assert.True(tree.Contains(50));
                Assert.True(tree.Contains(75));
                Assert.True(tree.Contains(25));
                Assert.True(tree.Contains(20));
                Assert.True(tree.Contains(35));
                Assert.True(tree.Contains(15));

                Assert.Equal(50, tree._root.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Color);
                Assert.Equal(25, tree._root.Left.Value);
                Assert.Equal(RedBlackTree.Color.Red, tree._root.Left.Color);
                Assert.Equal(100, tree._root.Right.Value);
                Assert.Equal(RedBlackTree.Color.Red, tree._root.Right.Color);
                Assert.Equal(20, tree._root.Left.Left.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Left.Left.Color);
                Assert.Equal(35, tree._root.Left.Right.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Left.Right.Color);
                Assert.Equal(75, tree._root.Right.Left.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Right.Left.Color);
                Assert.Equal(200, tree._root.Right.Right.Value);
                Assert.Equal(RedBlackTree.Color.Black, tree._root.Right.Right.Color);
                Assert.Equal(RedBlackTree.Color.Red, tree._root.Left.Left.Left.Color);
                Assert.Equal(15, tree._root.Left.Left.Left.Value);
            }
        }

        public class MassInsertTests
        {
            private readonly ITestOutputHelper _testOutputHelper;

            public MassInsertTests(ITestOutputHelper testOutputHelper)
            {
                _testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void MassInsert()
            {
                var data = Enumerable.Range(0, 1000).ToArray();
                var tree = new RedBlackTree();

                foreach (var item in data)
                {
                    tree.Insert(item);
                }

                foreach (var item in data)
                {
                    Assert.True(tree.Contains(item));
                }

                foreach (var item in tree)
                {
                    _testOutputHelper.WriteLine(item.ToString());
                }

                Assert.True(tree.IsValid());
            }


            [Fact]
            public void MassInsert__MassDelete()
            {
                var insert = Enumerable.Range(0, 1000).ToArray();
                var delete = insert.Take(100).ToArray();
                var tree = new RedBlackTree();

                foreach (var item in insert)
                {
                    tree.Insert(item);
                    tree.Insert(item);
                }

                foreach (var item in delete)
                {
                    tree.Remove(item);
                }

                foreach (var item in insert.Except(delete))
                {
                    Assert.True(tree.Contains(item));
                }

                foreach (var item in tree)
                {
                    _testOutputHelper.WriteLine(item.ToString());
                }

                Assert.True(tree.IsValid());
            }
        }
    }
}